namespace PureQL.CSharp.Model.Generator;

// A port of `scripts/normalize-schema.ts` of PureQL.TypeScript.Model, kept function for
// function so both models are generated from the same normalized schema.
//
// The PureQL schema (draft 2020-12) is type-directed: every expression node declares the
// type it yields, operators pick their operand rules with `if`/`then` on that declared
// type, and each slot narrows `expr@<context>` with a shallow check of the declared type
// (`allOf: [accepts.decimal, expr@row]`). This module resolves all of it statically:
//
// - every typed object (`field`, `literal`, `add@row`, …) is split into one variant per
//   exact declared type (`FieldInteger`, `AddIntegerNullableRow`), its operand rules merged;
// - every expression union is the list of variants it admits, so a type check on it
//   becomes a smaller union (`IntegerNullableRow = DeclaresIntegerRow | …`);
// - the remaining conditionals (query kinds, `oneOf`, `dependentRequired`) become unions.
//
// Rules a type cannot express (patterns, `contains`, a disjunction across operands) stay
// validation-only. Unknown patterns throw, so a future schema change cannot silently
// degrade the generated types.
internal static class SchemaNormalizer
{
    public const string DefsPrefix = "#/$defs/";

    /// <summary>The definition of a declared type: <c>{ name, nullable? }</c>.</summary>
    public const string TypeDef = "type";

    // Root-level annotations that may sit next to a root `if`/`then`/`else`.
    private static readonly string[] RootAnnotations =
    [
        "$schema",
        "$id",
        "$defs",
        "title",
        "version",
    ];

    // Keywords a type cannot express: they only reject values a validator checks.
    private static readonly string[] ValidationOnly =
    [
        "not",
        "contains",
        "minContains",
        "maxContains",
    ];

    // Array keywords kept when merging array constraints.
    private static readonly string[] ArrayKeywords =
    [
        "type",
        "items",
        "minItems",
        "maxItems",
        "uniqueItems",
    ];

    public static bool HasOnlyKeys(JsonMap node, params string[] keys)
    {
        return node.Keys.All(keys.Contains);
    }

    public static string Capitalize(string part)
    {
        return part.Length == 0 ? part : char.ToUpperInvariant(part[0]) + part[1..];
    }

    /// <summary><c>add.integer.nullable@row</c> → <c>AddIntegerNullableRow</c></summary>
    public static string ToTypeName(string defKey)
    {
        return string.Concat(
            defKey.Split('.', '@').Where(p => p.Length > 0).Select(Capitalize)
        );
    }

    public static string? RefKey(object? reference)
    {
        return
            reference is string text
            && text.StartsWith(DefsPrefix, StringComparison.Ordinal)
            ? text[DefsPrefix.Length..]
            : null;
    }

    public static JsonMap Ref(string key)
    {
        return new JsonMap { ["$ref"] = DefsPrefix + key };
    }

    public static List<string> Unique(IEnumerable<string> values)
    {
        List<string> result = [];
        foreach (string value in values)
        {
            if (!result.Contains(value))
            {
                result.Add(value);
            }
        }
        return result;
    }

    public static InvalidOperationException Fail(string message, object? node)
    {
        string json = node is string text ? text : Json.Write(node);
        return new InvalidOperationException(
            $"{message}: {(json.Length > 300 ? json[..300] : json)}"
        );
    }

    public static List<string> Strings(object? value)
    {
        return value is List<object?> list ? [.. list.Cast<string>()] : [];
    }

    /// <summary><c>add@row</c> + <c>integer.nullable</c> → <c>add.integer.nullable@row</c></summary>
    private static string VariantKey(string key, ExactType type)
    {
        int at = key.IndexOf('@', StringComparison.Ordinal);
        return at < 0 ? $"{key}.{type.Key}" : $"{key[..at]}.{type.Key}{key[at..]}";
    }

    public static string? OneRefKey(object? node)
    {
        return node is JsonMap map && HasOnlyKeys(map, "$ref")
            ? RefKey(map["$ref"])
            : null;
    }

    // ===== Generic rewrites =====

    /// <summary>
    /// <c>{ if, then, else: false }</c> — a guard that only narrows <c>then</c>;
    /// <c>{ if, then, else }</c> — a choice between two schemas.
    /// </summary>
    private static JsonMap RewriteIfThenElse(JsonMap node)
    {
        JsonMap rest = node.Without("if", "then", "else");
        if (!rest.Keys.All(RootAnnotations.Contains))
        {
            throw Fail("Unsupported keywords next to if/then/else", node);
        }
        if (node["else"] is false)
        {
            return node["then"] is JsonMap then
                ? rest.With(then)
                : throw Fail("Guard without a schema in then", node);
        }
        JsonMap result = new JsonMap(rest)
        {
            ["anyOf"] = new List<object?> { node["then"], node["else"] },
        };
        return result;
    }

    /// <summary>
    /// <c>oneOf: [{ required: [a] }, { required: [b] }]</c> on an object — exactly one of the
    /// listed properties must be present. Each variant keeps its own property and forbids
    /// the alternatives.
    /// </summary>
    private static JsonMap RewriteRequiredOneOf(JsonMap node)
    {
        List<JsonMap> branches = [.. ((List<object?>)node["oneOf"]!).Cast<JsonMap>()];
        JsonMap baseSchema = node.Without("oneOf");
        List<string> exclusive = [.. branches.SelectMany(b => Strings(b["required"]))];
        JsonMap baseProperties = baseSchema["properties"] as JsonMap ?? [];
        List<string> baseRequired = Strings(baseSchema["required"]);
        string? baseTitle = baseSchema["title"] as string;
        JsonMap baseWithoutTitle = baseSchema.Without("title");

        List<object?> variants = [];
        foreach (JsonMap branch in branches)
        {
            List<string> own = Strings(branch["required"]);
            JsonMap properties =
            [
                .. baseProperties.Select(p => new KeyValuePair<string, object?>(
                    p.Key,
                    own.Contains(p.Key) || !exclusive.Contains(p.Key) ? p.Value : false
                )),
            ];
            JsonMap variant = new JsonMap(baseWithoutTitle)
            {
                ["required"] = ToList(Unique([.. baseRequired, .. own])),
                ["properties"] = properties,
            };
            if (baseTitle is not null)
            {
                variant["title"] = baseTitle + string.Concat(own.Select(Capitalize));
            }
            variants.Add(variant);
        }
        return Titled(baseTitle, variants);
    }

    private static JsonMap Titled(string? title, List<object?> variants)
    {
        return title is null
            ? new JsonMap { ["anyOf"] = variants }
            : new JsonMap { ["title"] = title, ["anyOf"] = variants };
    }

    public static List<object?> ToList(IEnumerable<string> values)
    {
        return [.. values.Cast<object?>()];
    }

    private static bool IsRequiredOnlyOneOf(JsonMap node)
    {
        return node["oneOf"] is List<object?> oneOf
            && oneOf.All(b => b is JsonMap map && HasOnlyKeys(map, "required"));
    }

    /// <summary>Which properties a variant of an object requires and forbids.</summary>
    /// <param name="Name">Trigger properties this variant was split on, in order.</param>
    private sealed record Presence(
        List<string> Required,
        List<string> Forbidden,
        List<(string Key, bool Present)> Name
    );

    /// <summary>
    /// <c>dependentRequired</c> / <c>dependentSchemas</c> (with <c>anyOf</c> over
    /// <c>required</c>) on an object: a property that requires others. Splits the object
    /// into one variant per way to satisfy them, each with its triggers required or
    /// forbidden, named after them: <c>MainPlainQueryWithPagination</c>, ….
    /// </summary>
    private static JsonMap RewriteDependencies(JsonMap node)
    {
        JsonMap dependentRequired = node["dependentRequired"] as JsonMap ?? [];
        JsonMap dependentSchemas = node["dependentSchemas"] as JsonMap ?? [];
        JsonMap baseSchema = node.Without("dependentRequired", "dependentSchemas");
        Dictionary<string, List<string>> dependentKeys = dependentRequired.ToDictionary(
            p => p.Key,
            p => Strings(p.Value)
        );
        Dictionary<string, List<List<string>>> alternativesOf = [];
        foreach (KeyValuePair<string, object?> entry in dependentSchemas)
        {
            if (
                entry.Value is not JsonMap schema
                || !HasOnlyKeys(schema, "anyOf")
                || schema["anyOf"] is not List<object?> anyOf
                || !anyOf.All(b => b is JsonMap map && HasOnlyKeys(map, "required"))
            )
            {
                throw Fail("Unsupported dependent schema", entry.Value);
            }
            alternativesOf[entry.Key] =
            [
                .. anyOf.Select(b => Strings(((JsonMap)b!)["required"])),
            ];
        }
        List<string> baseRequired = Strings(baseSchema["required"]);
        JsonMap baseProperties = baseSchema["properties"] as JsonMap ?? [];
        string? baseTitle = baseSchema["title"] as string;
        JsonMap baseWithoutTitle = baseSchema.Without("title");

        // Every way to require `keys` and whatever they depend on; none if one is forbidden.
        List<Presence> RequireAll(Presence state, IReadOnlyList<string> keys)
        {
            List<Presence> states = [state];
            foreach (string key in keys)
            {
                states = [.. states.SelectMany(s => RequireKey(s, key))];
            }
            return states;
        }

        IEnumerable<Presence> RequireKey(Presence state, string key)
        {
            if (state.Forbidden.Contains(key))
            {
                return [];
            }
            if (state.Required.Contains(key))
            {
                return [state];
            }
            List<Presence> withKey = RequireAll(
                state with
                {
                    Required = [.. state.Required, key],
                },
                dependentKeys.GetValueOrDefault(key) ?? []
            );
            return !alternativesOf.TryGetValue(key, out List<List<string>>? alternatives)
                ? withKey
                : withKey.SelectMany(w =>
                    alternatives.Any(alt => alt.All(w.Required.Contains))
                        ? [w]
                        : alternatives.SelectMany(alt => RequireAll(w, alt))
                );
        }

        List<string> triggers = Unique([.. dependentKeys.Keys, .. alternativesOf.Keys]);
        List<Presence> states = RequireAll(new Presence([], [], []), baseRequired);
        foreach (string trigger in triggers)
        {
            states =
            [
                .. states.SelectMany(s =>
                    s.Forbidden.Contains(trigger) || s.Required.Contains(trigger)
                        ? [s]
                        : RequireAll(
                                s with
                                {
                                    Name = [.. s.Name, (trigger, true)],
                                },
                                [trigger]
                            )
                            .Prepend(
                                s with
                                {
                                    Forbidden = [.. s.Forbidden, trigger],
                                    Name = [.. s.Name, (trigger, false)],
                                }
                            )
                ),
            ];
        }

        List<object?> variants = [];
        foreach (Presence state in states)
        {
            JsonMap properties =
            [
                .. baseProperties.Select(p => new KeyValuePair<string, object?>(
                    p.Key,
                    state.Forbidden.Contains(p.Key) ? false : p.Value
                )),
            ];
            JsonMap variant = new JsonMap(baseWithoutTitle)
            {
                ["required"] = ToList(Unique([.. baseRequired, .. state.Required])),
                ["properties"] = properties,
            };
            if (baseTitle is not null)
            {
                variant["title"] =
                    baseTitle
                    + string.Concat(
                        state.Name.Select(n =>
                            (n.Present ? "With" : "Without") + Capitalize(n.Key)
                        )
                    );
            }
            variants.Add(variant);
        }
        return Titled(baseTitle, variants);
    }

    /// <summary>Splices untitled nested <c>anyOf</c>s into their parent, drops duplicate refs.</summary>
    private static JsonMap FlattenAnyOf(JsonMap node)
    {
        List<object?> items = [];
        HashSet<string> seenRefs = [];
        foreach (object? item in (List<object?>)node["anyOf"]!)
        {
            List<object?> nested =
                item is JsonMap map && HasOnlyKeys(map, "anyOf")
                    ? (List<object?>)map["anyOf"]!
                    : [item];
            foreach (object? n in nested)
            {
                if (
                    n is JsonMap reference
                    && reference["$ref"] is string target
                    && HasOnlyKeys(reference, "$ref")
                    && !seenRefs.Add(target)
                )
                {
                    continue;
                }
                items.Add(n);
            }
        }
        return new JsonMap(node) { ["anyOf"] = items };
    }

    /// <summary><c>{ if: { pattern }, then: { pattern } }</c> — a string format rule.</summary>
    private static bool IsPatternRule(object? node)
    {
        return node is JsonMap map
            && HasOnlyKeys(map, "if", "then")
            && map["if"] is JsonMap condition
            && HasOnlyKeys(condition, "pattern")
            && map["then"] is JsonMap then
            && HasOnlyKeys(then, "pattern");
    }

    private static void AssertNoConditionals(object? node)
    {
        if (node is List<object?> list)
        {
            list.ForEach(AssertNoConditionals);
            return;
        }
        if (node is not JsonMap map)
        {
            return;
        }
        foreach (KeyValuePair<string, object?> entry in map)
        {
            if (entry.Key is "if" or "then" && entry.Value is JsonMap)
            {
                throw Fail("Conditional left after normalization", node);
            }
            if (entry.Key is "properties" or "$defs" && entry.Value is JsonMap children)
            {
                foreach (object? child in children.Values)
                {
                    AssertNoConditionals(child);
                }
            }
            else
            {
                AssertNoConditionals(entry.Value);
            }
        }
    }

    private static void CollectRefs(object? node, HashSet<string> refs)
    {
        if (node is List<object?> list)
        {
            list.ForEach(n => CollectRefs(n, refs));
            return;
        }
        if (node is not JsonMap map)
        {
            return;
        }
        foreach (KeyValuePair<string, object?> entry in map)
        {
            string? target = entry.Key == "$ref" ? RefKey(entry.Value) : null;
            if (target is not null)
            {
                _ = refs.Add(target);
            }
            else
            {
                CollectRefs(entry.Value, refs);
            }
        }
    }

    /// <summary>The closed objects a union is made of, following refs and nested anyOfs.</summary>
    private static List<JsonMap> UnionMembers(object? node, JsonMap defs)
    {
        if (node is not JsonMap map)
        {
            throw Fail("Union member is not a schema", node);
        }
        string? key = RefKey(map["$ref"]);
        return key is not null
            ? UnionMembers(defs[key] ?? throw Fail("Dangling $ref", key), defs)
            : map["anyOf"] is List<object?> anyOf
                ?
                [
                    .. anyOf
                        .SelectMany(n => UnionMembers(n, defs))
                        .Distinct(ReferenceEqualityComparer.Instance)
                        .Cast<JsonMap>(),
                ]
            : map["additionalProperties"] is not false || map["properties"] is not JsonMap
                ? throw Fail("Union member is not a closed object", node)
            : [map];
    }

    /// <summary>
    /// Marks every property of a union that a member does not declare as forbidden in that
    /// member: the members share no discriminant, so this keeps them apart.
    /// </summary>
    private static void CloseUnion(object? node, JsonMap defs)
    {
        List<JsonMap> members = UnionMembers(node, defs);
        List<string> keys = Unique(
            members.SelectMany(m => ((JsonMap)m["properties"]!).Keys)
        );
        foreach (JsonMap member in members)
        {
            JsonMap properties = (JsonMap)member["properties"]!;
            foreach (string key in keys.Where(key => !properties.Has(key)))
            {
                properties[key] = false;
            }
        }
    }

    /// <summary>Keeps only the definitions reachable from the root schema.</summary>
    private static JsonMap PruneDefs(JsonMap root, JsonMap defs)
    {
        HashSet<string> reachable = [];
        Stack<object?> queue = new Stack<object?>();
        queue.Push(root);
        while (queue.Count > 0)
        {
            HashSet<string> refs = [];
            CollectRefs(queue.Pop(), refs);
            foreach (string r in refs)
            {
                if (!defs.Has(r))
                {
                    throw Fail("Dangling $ref", r);
                }
                if (reachable.Add(r))
                {
                    queue.Push(defs[r]);
                }
            }
        }
        return [.. defs.Where(entry => reachable.Contains(entry.Key))];
    }

    /// <summary>
    /// <c>{ if: { required }, then, else }</c> or
    /// <c>{ anyOf: [{ required }], allOf: [{ if: { required }, then }] }</c>.
    /// </summary>
    private static bool IsKeyDispatch(object? node)
    {
        static bool IsKeyCheck(object? n)
        {
            return n is JsonMap map && HasOnlyKeys(map, "required");
        }
        static bool IsIfElse(JsonMap map)
        {
            return HasOnlyKeys(map, "if", "then", "else") && IsKeyCheck(map["if"]);
        }
        static bool IsSelection(JsonMap map)
        {
            return HasOnlyKeys(map, "anyOf", "allOf")
                && map["anyOf"] is List<object?> anyOf
                && anyOf.All(IsKeyCheck)
                && map["allOf"] is List<object?> allOf
                && allOf.All(b =>
                    b is JsonMap branch
                    && HasOnlyKeys(branch, "if", "then")
                    && IsKeyCheck(branch["if"])
                );
        }
        return node is JsonMap map && (IsIfElse(map) || IsSelection(map));
    }

    /// <summary><c>expr@row</c> + <c>integer.nullable</c> → <c>declares.integer.nullable@row</c></summary>
    private static string GroupKey(string union, string type)
    {
        int at = union.IndexOf('@', StringComparison.Ordinal);
        return at < 0 ? $"declares.{type}.{union}" : $"declares.{type}{union[at..]}";
    }

    public static JsonMap Normalize(JsonMap schema)
    {
        if (schema["$defs"] is not JsonMap rawDefs)
        {
            throw Fail("Schema has no $defs", string.Join(", ", schema.Keys));
        }

        Normalizer normalizer = new Normalizer(rawDefs);
        JsonMap defs = normalizer.NormalizeDefs();

        Dictionary<string, string> names = [];
        foreach (string key in defs.Keys)
        {
            string title = ToTypeName(key);
            if (names.TryGetValue(title, out string? clash))
            {
                throw Fail(
                    $"Definitions \"{clash}\" and \"{key}\" map to the same name",
                    title
                );
            }
            names[title] = key;
        }

        JsonMap root = schema.Without("$defs");
        JsonMap finalRoot = (JsonMap)normalizer.Rewrite(root)!;
        JsonMap conditional =
        [
            .. root.Where(entry => !RootAnnotations.Contains(entry.Key)),
        ];
        if (IsKeyDispatch(conditional))
        {
            CloseUnion(finalRoot, defs);
        }
        foreach (string key in normalizer.KeyDispatches())
        {
            CloseUnion(defs[key], defs);
        }
        JsonMap result = new JsonMap(finalRoot)
        {
            ["$defs"] = PruneDefs(finalRoot, defs),
        };
        AssertNoConditionals(result);
        return result;
    }

    /// <summary>One of the declared types: <c>integer</c>, <c>integer.nullable</c>, ….</summary>
    public sealed record ExactType(string Key, string Name, bool Nullable);

    /// <summary>An object variant with one exact declared type, before its rules are merged.</summary>
    /// <param name="Parts">Refinements merged into the base object: operand rules, ….</param>
    private sealed record Variant(string Key, ExactType Type, List<JsonMap> Parts);

    private sealed record DeclaredRule(HashSet<string> Types, JsonMap Then);

    // ===== Type-directed normalization =====

    private sealed class Normalizer
    {
        private readonly List<ExactType> _types;
        private readonly Dictionary<string, HashSet<string>?> _typeChecks = [];
        private readonly Dictionary<string, List<Variant>> _plans = [];
        private readonly Dictionary<string, List<string>?> _unions = [];

        // Exact type of every variant, by variant key.
        private readonly Dictionary<string, string> _variantTypes = [];

        // Named unions, by their sorted variant keys: a view equal to one refers to it.
        private readonly Dictionary<string, string> _namedUnions = [];

        // Unions with several variants per type, split into one `declares.<type>@<ctx>`
        // group per type.
        private readonly OrderedDictionary<
            string,
            OrderedDictionary<string, List<string>>
        > _grouped = [];

        private readonly JsonMap _defs;

        public Normalizer(JsonMap defs)
        {
            _defs = defs;
            _types = ExactTypes();
        }

        private JsonMap Def(string key)
        {
            return _defs[key] as JsonMap ?? throw Fail("Dangling $ref", key);
        }

        /// <summary><c>type</c> → <c>[integer, integer.nullable, decimal, …]</c></summary>
        private List<ExactType> ExactTypes()
        {
            object? typeDef = _defs[TypeDef];
            return
                typeDef is not JsonMap { } map
                || map["properties"] is not JsonMap properties
                || properties["name"] is not JsonMap name
                || name["enum"] is not List<object?> names
                || !names.All(n => n is string)
                ? throw Fail(
                    "Schema has no `type` definition with an enum of names",
                    typeDef
                )
                :
                [
                    .. names
                        .Cast<string>()
                        .SelectMany(n =>
                            new[]
                            {
                                new ExactType(n, n, false),
                                new ExactType($"{n}.nullable", n, true),
                            }
                        ),
                ];
        }

        /// <summary>Whether a declared type object of type <paramref name="t"/> satisfies a schema.</summary>
        private bool TypeObjectAccepts(object? schema, ExactType t)
        {
            if (schema is true)
            {
                return true;
            }
            if (schema is not JsonMap map)
            {
                throw Fail("Unsupported declared type constraint", schema);
            }
            foreach (KeyValuePair<string, object?> entry in map)
            {
                if (entry.Key == "$ref")
                {
                    if (!TypeObjectAccepts(_defs[RefKey(entry.Value) ?? ""], t))
                    {
                        return false;
                    }
                }
                else if (entry.Key == "required")
                {
                    if (Strings(entry.Value).Contains("nullable") && !t.Nullable)
                    {
                        return false;
                    }
                }
                else if (entry.Key == "properties")
                {
                    foreach (
                        KeyValuePair<string, object?> property in (JsonMap)entry.Value!
                    )
                    {
                        JsonMap rule = (JsonMap)property.Value!;
                        List<object?>? allowed =
                            rule["enum"] as List<object?>
                            ?? (rule.Has("const") ? [rule["const"]] : null);
                        if (!HasOnlyKeys(rule, "enum", "const") || allowed is null)
                        {
                            throw Fail("Unsupported declared type constraint", rule);
                        }
                        if (property.Key == "name" && !allowed.Contains(t.Name))
                        {
                            return false;
                        }
                        // A non-null type omits `nullable`, so only a nullable one is checked.
                        if (
                            property.Key == "nullable"
                            && t.Nullable
                            && !allowed.Contains(true)
                        )
                        {
                            return false;
                        }
                        if (property.Key is not "name" and not "nullable")
                        {
                            throw Fail(
                                "Unsupported declared type property",
                                property.Key
                            );
                        }
                    }
                }
                else if (
                    entry.Key is not "type" and not "additionalProperties" and not "title"
                )
                {
                    throw Fail("Unsupported declared type constraint", schema);
                }
            }
            return true;
        }

        /// <summary>
        /// The exact types a shallow check of a node's declared type admits —
        /// <c>declares.integer</c>, <c>accepts.decimal.nullable</c>, <c>{ anyOf }</c> of
        /// them — or null for any other schema.
        /// </summary>
        public HashSet<string>? TypeCheck(object? node)
        {
            if (node is not JsonMap map)
            {
                return null;
            }
            string? key = OneRefKey(map);
            if (key is not null)
            {
                if (_typeChecks.TryGetValue(key, out HashSet<string>? cached))
                {
                    return cached;
                }
                _typeChecks[key] = null;
                HashSet<string>? computed = TypeCheck(_defs[key]);
                _typeChecks[key] = computed;
                return computed;
            }
            object? items = map["anyOf"] ?? map["allOf"];
            if (
                items is List<object?> list
                && (HasOnlyKeys(map, "anyOf") || HasOnlyKeys(map, "allOf"))
            )
            {
                List<HashSet<string>?> sets = [.. list.Select(TypeCheck)];
                if (sets.Any(s => s is null))
                {
                    return null;
                }
                bool any = map.Has("anyOf");
                return
                [
                    .. _types
                        .Select(t => t.Key)
                        .Where(t =>
                            any
                                ? sets.Any(s => s!.Contains(t))
                                : sets.All(s => s!.Contains(t))
                        ),
                ];
            }
            if (
                map["type"] is "object"
                && HasOnlyKeys(map, "type", "required", "properties")
                && map["properties"] is JsonMap properties
                && HasOnlyKeys(properties, "type")
            )
            {
                object? rule = properties["type"];
                return
                [
                    .. _types.Where(t => TypeObjectAccepts(rule, t)).Select(t => t.Key),
                ];
            }
            return null;
        }

        /// <summary>An object whose <c>type</c> property is a declared type.</summary>
        public static bool IsTyped(object? def)
        {
            return def is JsonMap map
                && map["type"] is "object"
                && map["properties"] is JsonMap properties
                && properties["type"] is JsonMap type
                && RefKey(type["$ref"]) == TypeDef;
        }

        /// <summary>One variant per exact type the object may declare, with its rules.</summary>
        private List<Variant> Plan(string key)
        {
            if (_plans.TryGetValue(key, out List<Variant>? cached))
            {
                return cached;
            }
            JsonMap def = Def(key);
            List<object?> allOf = def["allOf"] as List<object?> ?? [];
            JsonMap baseSchema = def.Without("allOf");
            object? typeRule = ((JsonMap)baseSchema["properties"]!)["type"];
            List<ExactType> allowed =
            [
                .. _types.Where(t => TypeObjectAccepts(typeRule, t)),
            ];
            List<DeclaredRule> declared = [];
            List<JsonMap> operand = [];
            foreach (object? item in allOf)
            {
                if (
                    item is not JsonMap branch
                    || !HasOnlyKeys(branch, "if", "then")
                    || branch["then"] is not JsonMap then
                )
                {
                    throw Fail("Unsupported rule of a typed object", item);
                }
                HashSet<string>? own = TypeCheck(branch["if"]);
                if (own is not null)
                {
                    declared.Add(new DeclaredRule(own, then));
                }
                else if (IsOperandCondition(branch["if"]))
                {
                    operand.Add(branch);
                }
                else
                {
                    throw Fail("Unsupported condition of a typed object", branch["if"]);
                }
            }

            List<Variant> variants;
            if (operand.Count > 0)
            {
                // `equal`: one variant per operand type, all declaring the same result type.
                if (declared.Count > 0 || allowed.Count != 1)
                {
                    throw Fail(
                        "Operand rules on an object that declares several types",
                        key
                    );
                }
                variants =
                [
                    .. operand.Select(b => new Variant(
                        OneRefKey(b["then"])
                            ?? throw Fail("Operand rule without a definition", b),
                        allowed[0],
                        [(JsonMap)b["if"]!, Deref((JsonMap)b["then"]!)]
                    )),
                ];
            }
            else
            {
                variants =
                    declared.Count == 0 && allowed.Count == 1
                        ? [new Variant(key, allowed[0], [])]
                        :
                        [
                            .. allowed.Select(t =>
                            {
                                List<DeclaredRule> rules =
                                [
                                    .. declared.Where(d => d.Types.Contains(t.Key)),
                                ];
                                if (rules.Count > 1)
                                {
                                    throw Fail($"Several rules for type {t.Key}", key);
                                }
                                string? target =
                                    rules.Count == 1 ? OneRefKey(rules[0].Then) : null;
                                return new Variant(
                                    target ?? VariantKey(key, t),
                                    t,
                                    [.. rules.Select(r => Deref(r.Then))]
                                );
                            }),
                        ];
            }
            foreach (Variant variant in variants)
            {
                _variantTypes[variant.Key] = variant.Type.Key;
            }
            _plans[key] = variants;
            return variants;
        }

        /// <summary><c>{ required: [left], properties: { left: accepts.decimal.nullable } }</c></summary>
        private bool IsOperandCondition(object? node)
        {
            return node is JsonMap map
                && HasOnlyKeys(map, "required", "properties")
                && map["properties"] is JsonMap properties
                && properties.Values.All(p => TypeCheck(p) is not null);
        }

        private JsonMap Deref(JsonMap node)
        {
            string? key = OneRefKey(node);
            return key is null ? node : Def(key);
        }

        /// <summary>
        /// The variants an expression schema admits, or null if it is not one: a typed
        /// object, a dispatch over typed objects or a type check of one.
        /// </summary>
        public List<string>? Variants(object? node)
        {
            if (node is not JsonMap map)
            {
                return null;
            }
            string? key = OneRefKey(map);
            if (key is not null)
            {
                if (_unions.TryGetValue(key, out List<string>? cached))
                {
                    return cached;
                }
                _unions[key] = null;
                List<string>? computed = DefVariants(key);
                _unions[key] = computed;
                return computed;
            }
            // `$ref: type` with constraints on the declared type itself.
            if (
                RefKey(map["$ref"]) == TypeDef
                && HasOnlyKeys(map, "$ref", "required", "properties")
            )
            {
                return
                [
                    .. _types
                        .Where(t => TypeObjectAccepts(map, t))
                        .Select(t => $"type.{t.Key}"),
                ];
            }
            if (HasOnlyKeys(map, "type", "if", "then", "else") && map.Has("if"))
            {
                return Concat([map["then"], map["else"]]);
            }
            if (map["anyOf"] is List<object?> anyOf && HasOnlyKeys(map, "anyOf"))
            {
                return Concat(anyOf);
            }
            if (map["allOf"] is List<object?> allOf)
            {
                if (HasOnlyKeys(map, "allOf"))
                {
                    return Filter(allOf);
                }
                // A dispatch on `operator` or on the leaf's key: each branch selects a schema.
                bool isDispatch = allOf.All(b =>
                    b is JsonMap branch
                    && HasOnlyKeys(branch, "if", "then")
                    && OneRefKey(branch["then"]) is not null
                );
                bool restIsSelector =
                    HasOnlyKeys(map, "allOf", "properties", "anyOf")
                    && (
                        map["properties"] is not JsonMap properties
                        || HasOnlyKeys(properties, "operator")
                    )
                    && (
                        map["anyOf"] is not List<object?> selectors
                        || selectors.All(b =>
                            b is JsonMap s && HasOnlyKeys(s, "required")
                        )
                    );
                if (isDispatch && restIsSelector)
                {
                    return Concat([.. allOf.Select(b => ((JsonMap)b!)["then"])]);
                }
            }
            return null;
        }

        private List<string>? DefVariants(string key)
        {
            if (key == TypeDef)
            {
                return
                [
                    .. _types.Select(t =>
                    {
                        _variantTypes[$"type.{t.Key}"] = t.Key;
                        return $"type.{t.Key}";
                    }),
                ];
            }
            object? def = _defs[key];
            return IsTyped(def) ? [.. Plan(key).Select(v => v.Key)] : Variants(def);
        }

        private List<string>? Concat(IEnumerable<object?> items)
        {
            List<List<string>?> lists = [.. items.Select(Variants)];
            return lists.Any(l => l is null) ? null : Unique(lists.SelectMany(l => l!));
        }

        /// <summary><c>[accepts.integer, expr@row]</c> → the variants of <c>expr@row</c> declaring an integer.</summary>
        private List<string>? Filter(IEnumerable<object?> items)
        {
            List<string>? result = null;
            HashSet<string>? types = null;
            foreach (object? item in items)
            {
                HashSet<string>? check = TypeCheck(item);
                if (check is not null)
                {
                    types = types is null ? check : [.. types.Where(check.Contains)];
                    continue;
                }
                List<string>? variants = Variants(item);
                if (variants is null)
                {
                    return null;
                }
                result = result is null ? variants : [.. result.Where(variants.Contains)];
            }
            return result is null ? null
                : types is null ? result
                : [.. result.Where(v => types.Contains(TypeOf(v)))];
        }

        private string TypeOf(string variant)
        {
            return _variantTypes.TryGetValue(variant, out string? type)
                ? type
                : throw Fail("Variant without a declared type", variant);
        }

        private static string SortedKey(IEnumerable<string> variants)
        {
            return string.Join(' ', variants.Order(StringComparer.Ordinal));
        }

        /// <summary>Refers to a set of variants: a named union equal to it, groups, or the variants.</summary>
        private JsonMap View(List<string> variants, string? defining = null)
        {
            if (variants.Count == 0)
            {
                throw Fail("A type check that admits no expression", defining ?? "");
            }
            if (
                _namedUnions.TryGetValue(SortedKey(variants), out string? named)
                && defining is null
            )
            {
                return Ref(named);
            }
            foreach (
                KeyValuePair<
                    string,
                    OrderedDictionary<string, List<string>>
                > entry in _grouped
            )
            {
                List<string> types = Unique(variants.Select(TypeOf));
                List<string> covered =
                [
                    .. types.SelectMany(t => entry.Value.GetValueOrDefault(t) ?? []),
                ];
                if (
                    entry.Key != defining
                    && covered.Count == variants.Count
                    && variants.All(covered.Contains)
                )
                {
                    return Union(
                        [.. types.Select(t => Ref(GroupKey(entry.Key, t)))],
                        defining
                    );
                }
            }
            return Union([.. variants.Select(Ref)], defining);
        }

        /// <summary>A definition stays a union even of one member.</summary>
        private static JsonMap Union(List<JsonMap> refs, string? defining)
        {
            return refs.Count == 1 && defining is null
                ? refs[0]
                : new JsonMap { ["anyOf"] = refs.Cast<object?>().ToList() };
        }

        /// <summary>Intersects the schemas one property must satisfy at once.</summary>
        private object? Combine(List<object?> schemas)
        {
            List<object?> parts =
            [
                .. schemas.Where(s => s is not true and not JsonMap { Count: 0 }),
            ];
            if (parts.Count == 0)
            {
                return true;
            }
            if (
                parts.Any(p =>
                    p is JsonMap map
                    && (map["type"] is "array" || map.Has("items") || map.Has("contains"))
                )
            )
            {
                return CombineArrays(parts);
            }
            // `{ $ref: decimal@row, anyOf: [declares.decimal, ...] }` is two constraints.
            List<object?> pieces =
            [
                .. parts.SelectMany(p =>
                    p is JsonMap map
                    && map.Has("anyOf")
                    && map["$ref"] is string
                    && HasOnlyKeys(map, "$ref", "anyOf")
                        ? new object?[]
                        {
                            new JsonMap { ["$ref"] = map["$ref"] },
                            new JsonMap { ["anyOf"] = map["anyOf"] },
                        }
                        : [p]
                ),
            ];
            List<object?> sources = [.. pieces.Where(p => TypeCheck(p) is null)];
            if (sources.Count == 1 && pieces.Count == 1)
            {
                return Rewrite(sources[0]);
            }
            List<string>? variants = Filter(pieces);
            if (variants is null || sources.Count == 0)
            {
                throw Fail("Cannot intersect property constraints", parts);
            }
            if (sources.Count == 1)
            {
                List<string>? all = Variants(sources[0]);
                if (all is not null && all.Count == variants.Count)
                {
                    return Rewrite(sources[0]);
                }
            }
            return View(variants);
        }

        private JsonMap CombineArrays(List<object?> parts)
        {
            JsonMap result = [];
            List<object?> items = [];
            foreach (object? part in parts)
            {
                if (part is not JsonMap map)
                {
                    throw Fail("Cannot intersect an array with a non-array", parts);
                }
                foreach (KeyValuePair<string, object?> entry in map)
                {
                    if (entry.Key == "items")
                    {
                        items.Add(entry.Value);
                    }
                    else if (entry.Key == "minItems")
                    {
                        result["minItems"] = Math.Max(
                            (double)entry.Value!,
                            result["minItems"] as double? ?? 0
                        );
                    }
                    else if (ArrayKeywords.Contains(entry.Key))
                    {
                        result[entry.Key] = entry.Value;
                    }
                    else if (!ValidationOnly.Contains(entry.Key))
                    {
                        throw Fail("Unsupported array keyword", part);
                    }
                }
            }
            if (items.Count > 0)
            {
                result["items"] = Combine(items);
            }
            return result;
        }

        /// <summary>Merges the rules a variant's type selects into the base object.</summary>
        private JsonMap Materialize(JsonMap baseSchema, Variant variant)
        {
            List<string> required = Strings(baseSchema["required"]);
            OrderedDictionary<string, List<object?>> constraints = [];
            foreach (
                KeyValuePair<string, object?> entry in (JsonMap)baseSchema["properties"]!
            )
            {
                constraints[entry.Key] = [entry.Value];
            }
            HashSet<string> forbidden = [];
            void Merge(JsonMap part)
            {
                foreach (KeyValuePair<string, object?> entry in part)
                {
                    if (entry.Key == "required")
                    {
                        required.AddRange(Strings(entry.Value));
                    }
                    else if (entry.Key == "properties")
                    {
                        foreach (
                            KeyValuePair<string, object?> rule in (JsonMap)entry.Value!
                        )
                        {
                            List<object?> list =
                                constraints.GetValueOrDefault(rule.Key)
                                ?? throw Fail("Rule for an unknown property", rule.Key);
                            list.Add(rule.Value);
                        }
                    }
                    else if (entry.Key == "allOf")
                    {
                        foreach (
                            JsonMap rule in ((List<object?>)entry.Value!).Cast<JsonMap>()
                        )
                        {
                            if (
                                HasOnlyKeys(rule, "not")
                                && rule["not"] is JsonMap not
                                && HasOnlyKeys(not, "required")
                            )
                            {
                                forbidden.UnionWith(Strings(not["required"]));
                            }
                            else if (HasOnlyKeys(rule, "required", "properties"))
                            {
                                Merge(rule);
                            }
                            else if (!HasOnlyKeys(rule, "anyOf"))
                            {
                                // `anyOf` here is a disjunction across operands ("one of
                                // them is nullable"): validation-only, like `contains`.
                                throw Fail("Unsupported rule of a typed object", rule);
                            }
                        }
                    }
                    else
                    {
                        throw Fail(
                            "Unsupported keyword in a rule of a typed object",
                            part
                        );
                    }
                }
            }
            variant.Parts.ForEach(Merge);

            JsonMap properties = [];
            foreach (KeyValuePair<string, List<object?>> entry in constraints)
            {
                if (forbidden.Contains(entry.Key))
                {
                    if (required.Contains(entry.Key))
                    {
                        throw Fail("A property both required and forbidden", entry.Key);
                    }
                    properties[entry.Key] = false;
                }
                else
                {
                    properties[entry.Key] =
                        entry.Key == "type"
                            ? Ref($"type.{variant.Type.Key}")
                            : Combine(entry.Value);
                }
            }
            return new JsonMap(baseSchema.Without("allOf"))
            {
                ["required"] = ToList(Unique(required)),
                ["properties"] = properties,
            };
        }

        /// <summary>Rewrites a schema with no typed objects of its own: queries, lists, ….</summary>
        public object? Rewrite(object? node)
        {
            if (node is List<object?> list)
            {
                return list.Select(Rewrite).ToList();
            }
            if (node is not JsonMap map)
            {
                return node;
            }
            // A type check of an expression union, or of the declared type itself.
            if (
                (HasOnlyKeys(map, "allOf") && Variants(map) is not null)
                || (RefKey(map["$ref"]) == TypeDef && !HasOnlyKeys(map, "$ref"))
            )
            {
                return View(Variants(map)!);
            }

            JsonMap result = [];
            foreach (KeyValuePair<string, object?> entry in map)
            {
                if (ValidationOnly.Contains(entry.Key))
                {
                    continue;
                }
                if (entry.Key == "allOf")
                {
                    List<object?> rules =
                    [
                        .. ((List<object?>)entry.Value!).Where(r => !IsPatternRule(r)),
                    ];
                    if (rules.Count > 0)
                    {
                        result["allOf"] = Rewrite(rules);
                    }
                    continue;
                }
                result[entry.Key] = entry.Key is "properties" or "dependentSchemas"
                    ? new JsonMap(
                        ((JsonMap)entry.Value!).Select(p => new KeyValuePair<
                            string,
                            object?
                        >(p.Key, Rewrite(p.Value)))
                    )
                    : Rewrite(entry.Value);
            }

            // `{ if, then }` without `else` only occurs in typed objects, resolved there.
            if (result.Has("if") && result.Has("else"))
            {
                result = RewriteIfThenElse(result);
            }
            if (IsRequiredOnlyOneOf(result))
            {
                result = RewriteRequiredOneOf(result);
            }
            if (result.Has("dependentRequired") || result.Has("dependentSchemas"))
            {
                result = RewriteDependencies(result);
            }
            if (result["anyOf"] is List<object?>)
            {
                result = FlattenAnyOf(result);
            }
            return result;
        }

        /// <summary>
        /// Definitions that pick one of their members by the keys a value has — the query
        /// kinds and the leaves. Their members share no discriminant, so they are closed.
        /// </summary>
        public IEnumerable<string> KeyDispatches()
        {
            return _defs.Keys.Where(key => IsKeyDispatch(_defs[key]));
        }

        /// <summary>The normalized definitions, titled after their keys.</summary>
        public JsonMap NormalizeDefs()
        {
            List<string> keys = [.. _defs.Keys];
            // Every union is resolved first, so views can refer to named unions and groups.
            foreach (string key in keys)
            {
                List<string>? variants = Variants(Ref(key));
                object? def = _defs[key];
                if (variants is null)
                {
                    continue;
                }
                // Dispatch-only definitions (`operator@row`, `leaf@row`) are spliced.
                bool isDispatch =
                    def is JsonMap dispatch
                    && dispatch["allOf"] is List<object?>
                    && !HasOnlyKeys(dispatch, "allOf");
                if (!IsTyped(def) && isDispatch)
                {
                    continue;
                }
                _ = _namedUnions.TryAdd(SortedKey(variants), key);
                if (def is JsonMap conditional && conditional.Has("if"))
                {
                    OrderedDictionary<string, List<string>> groups = [];
                    foreach (string variant in variants)
                    {
                        string type = TypeOf(variant);
                        groups[type] = [.. groups.GetValueOrDefault(type) ?? [], variant];
                    }
                    if (groups.Values.Any(g => g.Count > 1))
                    {
                        _grouped[key] = groups;
                    }
                }
            }

            // Variants take the place of the rule definitions they were named after.
            HashSet<string> variantKeys =
            [
                .. _plans.SelectMany(p =>
                    p.Value.Select(v => v.Key).Where(k => k != p.Key)
                ),
            ];
            JsonMap result = [];
            void Add(string key, JsonMap schema)
            {
                if (result.Has(key))
                {
                    throw Fail("Definition written twice", key);
                }
                result[key] = new JsonMap { ["title"] = ToTypeName(key) }.With(schema);
            }
            foreach (string key in keys)
            {
                object? def = _defs[key];
                if (IsTyped(def))
                {
                    JsonMap typed = (JsonMap)def!;
                    List<Variant> variants = Plan(key);
                    if (variants.Count == 1 && variants[0].Key == key)
                    {
                        Add(key, (JsonMap)Rewrite(Materialize(typed, variants[0]))!);
                        continue;
                    }
                    Add(key, View([.. variants.Select(v => v.Key)], key));
                    foreach (Variant variant in variants)
                    {
                        Add(variant.Key, (JsonMap)Rewrite(Materialize(typed, variant))!);
                    }
                }
                else if (variantKeys.Contains(key))
                {
                    continue;
                }
                else if (key == TypeDef)
                {
                    Add(key, View(Variants(Ref(key))!, key));
                    foreach (ExactType t in _types)
                    {
                        Add(
                            $"type.{t.Key}",
                            new JsonMap
                            {
                                ["type"] = "object",
                                ["required"] = ToList(
                                    t.Nullable ? ["name", "nullable"] : ["name"]
                                ),
                                ["properties"] = new JsonMap
                                {
                                    ["name"] = new JsonMap { ["const"] = t.Name },
                                    ["nullable"] = t.Nullable
                                        ? new JsonMap { ["const"] = true }
                                        : false,
                                },
                                ["additionalProperties"] = false,
                            }
                        );
                    }
                }
                else if (
                    _grouped.TryGetValue(
                        key,
                        out OrderedDictionary<string, List<string>>? groups
                    )
                )
                {
                    Add(
                        key,
                        new JsonMap
                        {
                            ["anyOf"] = groups
                                .Keys.Select(t => (object?)Ref(GroupKey(key, t)))
                                .ToList(),
                        }
                    );
                    foreach (KeyValuePair<string, List<string>> group in groups)
                    {
                        Add(
                            GroupKey(key, group.Key),
                            new JsonMap
                            {
                                ["anyOf"] = group
                                    .Value.Select(v => (object?)Ref(v))
                                    .ToList(),
                            }
                        );
                    }
                }
                else
                {
                    List<string>? variants = Variants(Ref(key));
                    Add(
                        key,
                        variants is not null
                            ? View(variants, key)
                            // Titled first: variants split off by the rewrite are named after it.
                            : (JsonMap)
                                Rewrite(
                                    new JsonMap { ["title"] = ToTypeName(key) }.With(
                                        (JsonMap)def!
                                    )
                                )!
                    );
                }
            }
            return result;
        }
    }
}
