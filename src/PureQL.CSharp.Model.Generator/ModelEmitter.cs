using System.Text;
using static PureQL.CSharp.Model.Generator.SchemaNormalizer;

namespace PureQL.CSharp.Model.Generator;

/// <summary>
/// Turns the normalized schema into C# source files: every closed object into a sealed
/// record, every union into a flat C# <c>union</c> of the records it admits.
/// </summary>
/// <remarks>
/// C# unions do not nest the way TypeScript's do — a union only converts from its own
/// cases — so every union lists the records it reaches directly
/// (<c>DecimalNullableRow</c> holds <c>AddIntegerRow</c>, not <c>DeclaresIntegerRow</c>).
/// Unions with the same records share one type, named after the schema definition that is
/// not a <c>declares.*</c> group: <c>declares.integer@row</c> and <c>integer@row</c> are
/// both <c>IntegerRow</c>.
/// </remarks>
internal sealed class ModelEmitter(JsonMap normalized)
{
    public const string RootNamespace = "PureQL.CSharp.Model";

    private const int MaxLineLength = 90;

    private static readonly Dictionary<string, string> Contexts = new Dictionary<
        string,
        string
    >
    {
        ["row"] = "RowExpressions",
        ["projection"] = "ProjectionExpressions",
        ["group"] = "GroupExpressions",
        ["total"] = "TotalExpressions",
    };

    private static readonly Dictionary<string, string> Leaves = new Dictionary<
        string,
        string
    >
    {
        ["field"] = "Fields",
        ["param"] = "Parameters",
        ["literal"] = "Literals",
        ["key"] = "Keys",
        ["type"] = "Types",
        ["list"] = "Lists",
    };

    // `value.<type>`: the CLR type a literal value of the schema type is held in.
    private static readonly Dictionary<string, string> Values = new Dictionary<
        string,
        string
    >
    {
        ["value.integer"] = "long",
        ["value.decimal"] = "decimal",
        ["value.string"] = "string",
        ["value.boolean"] = "bool",
        ["value.date"] = "DateOnly",
        ["value.time"] = "TimeOnly",
        ["value.datetime"] = "DateTimeOffset",
        ["value.uuid"] = "Guid",
    };

    // Enum properties by name: the C# enum, and the member an absent property means.
    private static readonly Dictionary<string, EnumDeclaration> Enums = new Dictionary<
        string,
        EnumDeclaration
    >
    {
        ["kind"] = new EnumDeclaration(
            "JoinKind",
            null,
            ["inner", "left", "right", "full"]
        ),
        ["direction"] = new EnumDeclaration("SortDirection", "asc", ["desc"]),
        ["over"] = new EnumDeclaration("AggregateOver", "group", ["all"]),
    };

    private static readonly HashSet<string> Keywords =
    [
        "abstract",
        "as",
        "base",
        "bool",
        "break",
        "byte",
        "case",
        "catch",
        "char",
        "checked",
        "class",
        "const",
        "continue",
        "decimal",
        "default",
        "delegate",
        "do",
        "double",
        "else",
        "enum",
        "event",
        "explicit",
        "extern",
        "false",
        "finally",
        "fixed",
        "float",
        "for",
        "foreach",
        "goto",
        "if",
        "implicit",
        "in",
        "int",
        "interface",
        "internal",
        "is",
        "lock",
        "long",
        "namespace",
        "new",
        "null",
        "object",
        "operator",
        "out",
        "override",
        "params",
        "private",
        "protected",
        "public",
        "readonly",
        "ref",
        "return",
        "sbyte",
        "sealed",
        "short",
        "sizeof",
        "stackalloc",
        "static",
        "string",
        "struct",
        "switch",
        "this",
        "throw",
        "true",
        "try",
        "typeof",
        "uint",
        "ulong",
        "unchecked",
        "unsafe",
        "ushort",
        "using",
        "virtual",
        "void",
        "volatile",
        "while",
    ];

    private readonly JsonMap _root = normalized;
    private readonly JsonMap _defs = (JsonMap)normalized["$defs"]!;

    // Every record and union the schema defines, by C# name.
    private readonly Dictionary<string, Declaration> _declarations = [];

    // The records each union definition admits, by definition key.
    private readonly Dictionary<string, List<string>> _unionMembers = [];

    // The C# name of the union of a set of records, by their sorted names.
    private readonly Dictionary<string, string> _unionNames = [];

    /// <summary>
    /// The interfaces of a typed record, by the properties it has: an operator, a field
    /// (<c>source</c>, <c>field</c>), a subquery column (<c>subquery</c>, <c>field</c>),
    /// a parameter, a key or a literal (<c>value</c>).
    /// </summary>
    private static List<string> Interfaces(JsonMap properties, bool isOperator)
    {
        bool Has(string key)
        {
            return properties.Has(key) && properties[key] is not false;
        }
        List<string> interfaces = [];
        if (isOperator)
        {
            interfaces.Add("IOperator");
        }
        if (Has("source") && Has("field"))
        {
            interfaces.Add("IField");
        }
        if (Has("subquery") && Has("field"))
        {
            interfaces.Add("ISubqueryColumn");
        }
        if (Has("param"))
        {
            interfaces.Add("IParameter");
        }
        if (Has("key"))
        {
            interfaces.Add("IKey");
        }
        if (Has("value"))
        {
            interfaces.Add("ILiteral");
        }
        return interfaces;
    }

    // The namespace of each hand-shaped interface.
    private static readonly Dictionary<string, string> InterfaceNamespaces =
        new Dictionary<string, string>
        {
            ["IType"] = "Types",
            ["IOperator"] = "",
            ["IField"] = "Fields",
            ["IParameter"] = "Parameters",
            ["ILiteral"] = "Literals",
            ["IKey"] = "Keys",
            ["ISubqueryColumn"] = "Lists",
        };

    private abstract record Declaration(string Name, string Namespace);

    /// <param name="TypeKey">The <c>type.*</c> definition the record declares, if any.</param>
    private sealed record RecordDeclaration(
        string Name,
        string Namespace,
        string? DefKey,
        JsonMap Schema,
        string? TypeKey
    ) : Declaration(Name, Namespace);

    private sealed record UnionDeclaration(
        string Name,
        string Namespace,
        string? DefKey,
        List<string> Cases
    ) : Declaration(Name, Namespace);

    /// <param name="Absent">The member an absent property means; null if it is required.</param>
    private sealed record EnumDeclaration(
        string Name,
        string? Absent,
        List<string> Values
    );

    /// <summary>Where an anonymous object of a union comes from.</summary>
    private sealed record Owner(string Title, string Namespace);

    private sealed record Property(
        string JsonName,
        string Type,
        bool Required,
        string? Default
    )
    {
        public string Name => Capitalize(JsonName);

        public string Parameter =>
            Keywords.Contains(JsonName) ? "@" + JsonName : JsonName;
    }

    /// <summary>The C# files of the model, by path relative to the project directory.</summary>
    public SortedDictionary<string, string> Emit()
    {
        foreach (KeyValuePair<string, object?> entry in _defs)
        {
            if (entry.Value is JsonMap def && def.Has("anyOf"))
            {
                _ = UnionDefMembers(entry.Key);
            }
        }
        NameUnions();

        UnionDeclaration root = new UnionDeclaration(
            "PureQLQuery",
            "",
            null,
            Members(_root, new Owner("PureQLQuery", ""))
        );
        _declarations[root.Name] = root;

        SortedDictionary<string, string> files = [with(StringComparer.Ordinal)];
        HashSet<string> emitted = [];
        Queue<string> queue = new Queue<string>([root.Name]);
        while (queue.Count > 0)
        {
            string name = queue.Dequeue();
            if (!emitted.Add(name))
            {
                continue;
            }
            Declaration declaration = _declarations[name];
            (string source, List<string> references) = declaration switch
            {
                RecordDeclaration record => EmitRecord(record),
                UnionDeclaration union => EmitUnion(union),
                _ => throw Fail("Unknown declaration", name),
            };
            files[PathOf(declaration.Namespace, name)] = source;
            foreach (string reference in references.Where(_declarations.ContainsKey))
            {
                queue.Enqueue(reference);
            }
        }
        foreach (EnumDeclaration declaration in Enums.Values)
        {
            files[PathOf("", declaration.Name)] = EmitEnum(declaration);
        }
        foreach ((string ns, string name, string source) in InterfaceFiles())
        {
            files[PathOf(ns, name)] = source;
        }
        return files;
    }

    private static string PathOf(string ns, string name)
    {
        return ns.Length == 0 ? $"{name}.cs" : $"{ns}/{name}.cs";
    }

    // ===== Resolution =====

    /// <summary>The namespace (relative to the root) of a definition's type.</summary>
    private static string NamespaceOf(string key)
    {
        if (
            key.StartsWith("selectItem@", StringComparison.Ordinal)
            || key.StartsWith("orderItem@", StringComparison.Ordinal)
        )
        {
            return "";
        }
        int at = key.IndexOf('@', StringComparison.Ordinal);
        if (at >= 0)
        {
            return Contexts.TryGetValue(key[(at + 1)..], out string? context)
                ? context
                : throw Fail("Unknown context", key);
        }
        int dot = key.IndexOf('.', StringComparison.Ordinal);
        return dot >= 0 && Leaves.TryGetValue(key[..dot], out string? leaf) ? leaf : "";
    }

    private JsonMap Def(string key)
    {
        return _defs[key] as JsonMap ?? throw Fail("Dangling $ref", key);
    }

    private List<string> UnionDefMembers(string key)
    {
        if (_unionMembers.TryGetValue(key, out List<string>? cached))
        {
            return cached;
        }
        JsonMap def = Def(key);
        List<string> members = Members(
            def,
            new Owner((string)def["title"]!, NamespaceOf(key))
        );
        _unionMembers[key] = members;
        return members;
    }

    /// <summary>The C# types a schema admits, following refs and nested unions.</summary>
    private List<string> Members(object? node, Owner owner)
    {
        if (node is not JsonMap map)
        {
            throw Fail("Union member is not a schema", node);
        }
        string? key = OneRefKey(map);
        if (key is not null)
        {
            JsonMap def = Def(key);
            return def.Has("anyOf") ? UnionDefMembers(key)
                : Values.TryGetValue(key, out string? value) ? [value]
                : Records(def, (string)def["title"]!, NamespaceOf(key), key);
        }
        if (map["anyOf"] is List<object?> anyOf)
        {
            Owner nested = map["title"] is string title
                ? owner with
                {
                    Title = title,
                }
                : owner;
            return Unique(anyOf.SelectMany(member => Members(member, nested)));
        }
        return map["type"] is "integer"
            ? ["long"]
            : map["type"] is "object"
            ? Records(
                map,
                map["title"] as string ?? AnonymousName(map, owner),
                owner.Namespace,
                null
            )
            : throw Fail("Unsupported union member", node);
    }

    /// <summary>
    /// A list's anonymous members are named after what they hold:
    /// <c>ListLiteralDecimal</c>, <c>ListParamDecimal</c>, <c>ListSubqueryColumnDecimal</c>.
    /// </summary>
    private static string AnonymousName(JsonMap node, Owner owner)
    {
        List<string> required = Strings(node["required"]);
        string kind = required switch
        {
            _ when required.Contains("value") => "Literal",
            _ when required.Contains("param") => "Param",
            _ when required.Contains("subquery") => "SubqueryColumn",
            _ => throw Fail("Cannot name an anonymous object", node),
        };
        return owner.Title.StartsWith("List", StringComparison.Ordinal)
            ? "List" + kind + owner.Title["List".Length..]
            : throw Fail($"Anonymous object outside a list in {owner.Title}", node);
    }

    /// <summary>
    /// The records of an object: one, or one per declared type when its <c>type</c> admits
    /// several (a subquery column is <c>ListSubqueryColumnDecimal</c> or
    /// <c>ListSubqueryColumnDecimalNullable</c>, as the column's type is).
    /// </summary>
    private List<string> Records(JsonMap schema, string name, string ns, string? defKey)
    {
        object? type = (schema["properties"] as JsonMap)?["type"];
        List<string?> typeKeys =
            type is JsonMap { } map && map["anyOf"] is List<object?> types
                ?
                [
                    .. types.Select(t =>
                        OneRefKey(t) ?? throw Fail("Unsupported type", t)
                    ),
                ]
                : [type is JsonMap reference ? RefKey(reference["$ref"]) : null];
        List<string> names = [];
        foreach (string? typeKey in typeKeys)
        {
            string recordName =
                typeKeys.Count == 1
                    ? name
                    : name
                        + (
                            typeKey!.EndsWith(".nullable", StringComparison.Ordinal)
                                ? "Nullable"
                                : ""
                        );
            RecordDeclaration record = new RecordDeclaration(
                recordName,
                ns,
                defKey,
                schema,
                typeKey
            );
            if (_declarations.TryGetValue(recordName, out Declaration? existing))
            {
                if (
                    existing is not RecordDeclaration known
                    || !ReferenceEquals(known.Schema, schema)
                    || known.TypeKey != typeKey
                )
                {
                    throw Fail("Two declarations with one name", recordName);
                }
            }
            else
            {
                _declarations[recordName] = record;
            }
            names.Add(recordName);
        }
        return names.Distinct().Count() != names.Count
            ? throw Fail("Records of one object with one name", name)
            : names;
    }

    private static string SetKey(IEnumerable<string> members)
    {
        return string.Join(' ', members.Order(StringComparer.Ordinal));
    }

    /// <summary>Names the union of every set of records a definition admits.</summary>
    private void NameUnions()
    {
        foreach (
            IGrouping<string, string> group in _unionMembers.Keys.GroupBy(k =>
                SetKey(_unionMembers[k])
            )
        )
        {
            List<string> keys = [.. group];
            List<string> preferred =
            [
                .. keys.Where(k => !k.StartsWith("declares.", StringComparison.Ordinal)),
            ];
            if (preferred.Count > 1)
            {
                throw Fail(
                    "Definitions with the same members",
                    string.Join(", ", preferred)
                );
            }
            string key = preferred.Count == 1 ? preferred[0] : keys[0];
            string name = ToTypeName(key);
            _unionNames[group.Key] = name;
            if (_declarations.ContainsKey(name))
            {
                throw Fail("Two declarations with one name", name);
            }
            _declarations[name] = new UnionDeclaration(
                name,
                NamespaceOf(key),
                key,
                _unionMembers[key]
            );
        }
    }

    /// <summary>
    /// The union of an inline <c>anyOf</c>: the named union with its records, or a new one
    /// named after the declared types it admits (<c>IntegerNullableOrDecimalNullableRow</c>)
    /// or after the property it types (<c>PaginationSkip</c>).
    /// </summary>
    private string InlineUnion(
        JsonMap node,
        string owner,
        string ownerNamespace,
        string property
    )
    {
        List<string> members = Members(node, new Owner(owner, ownerNamespace));
        if (_unionNames.TryGetValue(SetKey(members), out string? named))
        {
            return named;
        }
        List<string?> groups = [.. ((List<object?>)node["anyOf"]!).Select(OneRefKey)];
        string name;
        string ns;
        if (
            groups.All(g =>
                g is not null && g.StartsWith("declares.", StringComparison.Ordinal)
            )
        )
        {
            List<string> types =
            [
                .. groups.Select(g =>
                    g!["declares.".Length..g!.IndexOf('@', StringComparison.Ordinal)]
                ),
            ];
            string context = groups[0]![
                groups[0]!.IndexOf('@', StringComparison.Ordinal)..
            ];
            if (groups.Any(g => !g!.EndsWith(context, StringComparison.Ordinal)))
            {
                throw Fail("A union across contexts", node);
            }
            name = string.Join("Or", types.Select(ToTypeName)) + ToTypeName(context);
            ns = NamespaceOf(context);
        }
        else
        {
            name = owner + Capitalize(property);
            ns = ownerNamespace;
        }
        if (_declarations.TryGetValue(name, out Declaration? existing))
        {
            return
                existing is UnionDeclaration union
                && SetKey(union.Cases) == SetKey(members)
                ? name
                : throw Fail("Two declarations with one name", name);
        }
        _declarations[name] = new UnionDeclaration(name, ns, null, members);
        return name;
    }

    /// <summary>The C# type of a property, or null for one the record type implies.</summary>
    private string PropertyType(object? schema, RecordDeclaration record, string property)
    {
        if (schema is not JsonMap map)
        {
            throw Fail($"Unsupported property {record.Name}.{property}", schema);
        }
        string? key = OneRefKey(map);
        if (key is not null)
        {
            JsonMap def = Def(key);
            if (Values.TryGetValue(key, out string? value))
            {
                return value;
            }
            if (def.Has("anyOf"))
            {
                return _unionNames[SetKey(UnionDefMembers(key))];
            }
            List<string> records = Records(
                def,
                (string)def["title"]!,
                NamespaceOf(key),
                key
            );
            return records.Count == 1
                ? records[0]
                : throw Fail("A property of split records", key);
        }
        if (map.Has("anyOf"))
        {
            return InlineUnion(map, record.Name, record.Namespace, property);
        }
        if (map.Has("enum"))
        {
            EnumDeclaration declaration = Enums.TryGetValue(
                property,
                out EnumDeclaration? found
            )
                ? found
                : throw Fail($"Unknown enum {record.Name}.{property}", map);
            List<string> values = Strings(map["enum"]);
            return values.SequenceEqual(declaration.Values)
                ? declaration.Name
                : throw Fail($"Enum {declaration.Name} changed", map);
        }
        return map["type"] switch
        {
            "string" => "string",
            "integer" => "long",
            "boolean" => "bool",
            "array" => $"IEnumerable<{PropertyType(map["items"], record, property)}>",
            _ => throw Fail($"Unsupported property {record.Name}.{property}", map),
        };
    }

    // ===== Emission =====

    // The namespace a referenced type lives in; null for a CLR type.
    private string? NamespaceOfReference(string reference)
    {
        return _declarations.TryGetValue(reference, out Declaration? declaration)
            ? declaration.Namespace
            : InterfaceNamespaces.TryGetValue(reference, out string? ns) ? ns
            : Enums.Values.Any(e => e.Name == reference) ? ""
            : null;
    }

    private string Using(IEnumerable<string> references, string ns)
    {
        List<string> namespaces =
        [
            .. references
                .Select(NamespaceOfReference)
                .OfType<string>()
                // Every namespace is inside the root one, which needs no using.
                .Where(n => n != ns && n.Length > 0)
                .Distinct()
                .Select(n => n.Length == 0 ? RootNamespace : $"{RootNamespace}.{n}")
                .Order(StringComparer.Ordinal),
        ];
        return string.Concat(namespaces.Select(n => $"using {n};\n"));
    }

    private static string Namespace(string ns)
    {
        return ns.Length == 0 ? RootNamespace : $"{RootNamespace}.{ns}";
    }

    private static string Summary(string? defKey)
    {
        return defKey is null ? "" : $"/// <summary>PureQL <c>{defKey}</c>.</summary>\n";
    }

    private static List<string> TypeNames(string type)
    {
        return [.. type.Split('<', '>', ',', ' ').Where(t => t.Length > 0)];
    }

    private (string Source, List<string> References) EmitRecord(RecordDeclaration record)
    {
        if (
            record.DefKey is not null
            && record.DefKey.StartsWith("type.", StringComparison.Ordinal)
        )
        {
            return (EmitType(record), []);
        }
        JsonMap properties = (JsonMap)record.Schema["properties"]!;
        List<string> required = Strings(record.Schema["required"]);
        List<Property> members = [];
        bool isOperator = false;
        foreach (KeyValuePair<string, object?> entry in properties)
        {
            if (entry.Value is false)
            {
                continue;
            }
            if (entry.Key == "operator" && entry.Value is JsonMap op && op.Has("const"))
            {
                isOperator = true;
                continue;
            }
            if (
                entry.Key == "type"
                || (entry.Value is JsonMap { } nullValue && nullValue["type"] is "null")
            )
            {
                continue;
            }
            bool isRequired = required.Contains(entry.Key);
            string type = PropertyType(entry.Value, record, entry.Key);
            string? absent = Enums.Values.FirstOrDefault(e => e.Name == type)?.Absent;
            if (!isRequired && absent is null)
            {
                type += "?";
            }
            members.Add(
                new Property(
                    entry.Key,
                    type,
                    isRequired,
                    isRequired ? null
                        : absent is null ? "null"
                        : $"{type}.{Capitalize(absent)}"
                )
            );
        }

        string? typeName = record.TypeKey is null
            ? null
            : Records(
                    Def(record.TypeKey),
                    ToTypeName(record.TypeKey),
                    "Types",
                    record.TypeKey
                )
                .Single();
        List<string> interfaces = typeName is null
            ? []
            : Interfaces(properties, isOperator);
        if (typeName is not null && interfaces.Count == 0)
        {
            throw Fail("A typed record without an interface for its type", record.Name);
        }

        List<string> references =
        [
            .. members.SelectMany(m => TypeNames(m.Type.TrimEnd('?'))),
            .. typeName is null ? Array.Empty<string>() : [typeName, "IType"],
            .. interfaces,
        ];
        StringBuilder code = new StringBuilder();
        _ = code.Append(Using(references, record.Namespace));
        if (code.Length > 0)
        {
            _ = code.Append('\n');
        }
        _ = code.Append($"namespace {Namespace(record.Namespace)};\n\n");
        _ = code.Append(Summary(record.DefKey));
        string header = $"public sealed record {record.Name}";
        _ = code.Append(header);
        if (interfaces.Count > 0)
        {
            string list = string.Join(", ", interfaces);
            _ = code.Append(
                header.Length + 3 + list.Length > MaxLineLength
                    ? $"\n    : {list}"
                    : $" : {list}"
            );
        }
        _ = code.Append("\n{\n");

        List<Property> parameters =
        [
            .. members.Where(m => m.Required),
            .. members.Where(m => !m.Required),
        ];
        if (parameters.Count > 0)
        {
            List<string> arguments =
            [
                .. parameters.Select(p =>
                    p.Default is null
                        ? $"{p.Type} {p.Parameter}"
                        : $"{p.Type} {p.Parameter} = {p.Default}"
                ),
            ];
            string signature =
                $"    public {record.Name}({string.Join(", ", arguments)})";
            _ =
                signature.Length <= MaxLineLength
                    ? code.Append(signature).Append('\n')
                    : code.Append($"    public {record.Name}(\n")
                        .Append(string.Join(",\n", arguments.Select(a => "        " + a)))
                        .Append("\n    )\n");
            _ = code.Append("    {\n");
            foreach (Property p in members)
            {
                _ = code.Append($"        {p.Name} = {p.Parameter};\n");
            }
            _ = code.Append("    }\n");
        }
        foreach (Property p in members)
        {
            _ = code.Append($"\n    public {p.Type} {p.Name} {{ get; }}\n");
        }
        if (typeName is not null)
        {
            _ = code.Append(parameters.Count > 0 ? "\n" : "");
            _ = code.Append($"    public IType Type => new {typeName}();\n");
        }
        _ = code.Append("}\n");
        return (code.ToString(), references);
    }

    private static string EmitType(RecordDeclaration record)
    {
        JsonMap properties = (JsonMap)record.Schema["properties"]!;
        string name = (string)((JsonMap)properties["name"]!)["const"]!;
        bool nullable = properties["nullable"] is JsonMap { } n && n["const"] is true;
        return $"namespace {Namespace(record.Namespace)};\n\n"
            + Summary(record.DefKey)
            + $"public sealed record {record.Name} : IType\n{{\n"
            + $"    public string Name => \"{name}\";\n\n"
            + $"    public bool Nullable => {(nullable ? "true" : "false")};\n"
            + "}\n";
    }

    private (string Source, List<string> References) EmitUnion(UnionDeclaration union)
    {
        StringBuilder code = new StringBuilder();
        _ = code.Append(Using(union.Cases, union.Namespace));
        if (code.Length > 0)
        {
            _ = code.Append('\n');
        }
        _ = code.Append($"namespace {Namespace(union.Namespace)};\n\n");
        _ = code.Append(Summary(union.DefKey));
        string single =
            $"public readonly union {union.Name}({string.Join(", ", union.Cases)});";
        _ =
            single.Length <= MaxLineLength
                ? code.Append(single).Append('\n')
                : code.Append($"public readonly union {union.Name}(\n")
                    .Append(string.Join(",\n", union.Cases.Select(c => "    " + c)))
                    .Append("\n);\n");
        return (code.ToString(), union.Cases);
    }

    private static string EmitEnum(EnumDeclaration declaration)
    {
        List<string> members =
        [
            .. (declaration.Absent is null ? [] : new[] { declaration.Absent })
                .Concat(declaration.Values)
                .Select(Capitalize),
        ];
        return $"namespace {RootNamespace};\n\n"
            + $"public enum {declaration.Name}\n{{\n"
            + string.Concat(members.Select(m => $"    {m},\n"))
            + "}\n";
    }

    private static IEnumerable<(
        string Namespace,
        string Name,
        string Source
    )> InterfaceFiles()
    {
        static string Interface(
            string ns,
            string name,
            string usings,
            params string[] members
        )
        {
            return usings
                + $"namespace {Namespace(ns)};\n\n"
                + $"public interface {name}\n{{\n"
                + string.Join("\n", members.Select(m => $"    public {m} {{ get; }}\n"))
                + "}\n";
        }
        string types = $"using {RootNamespace}.Types;\n\n";
        yield return (
            "Types",
            "IType",
            Interface("Types", "IType", "", "string Name", "bool Nullable")
        );
        yield return ("", "IOperator", Interface("", "IOperator", types, "IType Type"));
        yield return (
            "Fields",
            "IField",
            Interface(
                "Fields",
                "IField",
                types,
                "string Source",
                "string Field",
                "IType Type"
            )
        );
        yield return (
            "Parameters",
            "IParameter",
            Interface("Parameters", "IParameter", types, "string Param", "IType Type")
        );
        yield return (
            "Literals",
            "ILiteral",
            Interface("Literals", "ILiteral", types, "IType Type")
        );
        yield return (
            "Keys",
            "IKey",
            Interface("Keys", "IKey", types, "string Key", "IType Type")
        );
        yield return (
            "Lists",
            "ISubqueryColumn",
            Interface(
                "Lists",
                "ISubqueryColumn",
                types,
                "string Subquery",
                "string Field",
                "IType Type"
            )
        );
    }
}
