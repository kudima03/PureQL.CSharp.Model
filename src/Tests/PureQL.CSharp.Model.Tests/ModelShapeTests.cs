using System.Reflection;
using OneOf;
using PureQL.CSharp.Model.Fields;
using PureQL.CSharp.Model.GroupKeys;
using PureQL.CSharp.Model.Keys;
using PureQL.CSharp.Model.Lists;
using PureQL.CSharp.Model.Literals;
using PureQL.CSharp.Model.Parameters;
using PureQL.CSharp.Model.SelectItems;
using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.Tests;

// Checks every public type of the model against the conventions it is built on:
// unions wrap each case at its own index, records keep their constructor arguments,
// and leaves report the type their name declares.
public sealed class ModelShapeTests
{
    private static readonly Type[] ModelTypes =
    [
        .. typeof(PureQLQuery)
            .Assembly.GetExportedTypes()
            .Where(type => type.IsSealed && !type.IsAbstract && !type.IsEnum),
    ];

    private static readonly Type[] TypedInterfaces =
    [
        typeof(IField),
        typeof(IParameter),
        typeof(ILiteral),
        typeof(IKey),
        typeof(ISelectItem),
        typeof(IGroupKey),
    ];

    private static bool IsUnion(Type type)
    {
        return type.BaseType is { IsGenericType: true } baseType
            && baseType
                .GetGenericTypeDefinition()
                .Name.StartsWith("OneOfBase`", StringComparison.Ordinal);
    }

    private static object Sample(Type type, int depth)
    {
        Assert.True(depth < 40, $"Sample construction does not terminate for {type}");
        Type? nullable = Nullable.GetUnderlyingType(type);
        return nullable is not null
            ? Sample(nullable, depth)
            : type switch
            {
                _ when type == typeof(string) => "name",
                _ when type == typeof(bool) => true,
                _ when type == typeof(int) => 3,
                _ when type == typeof(long) => 7L,
                _ when type == typeof(decimal) => 1.5m,
                _ when type == typeof(DateOnly) => new DateOnly(2024, 2, 29),
                _ when type == typeof(TimeOnly) => new TimeOnly(23, 59, 59),
                _ when type == typeof(DateTimeOffset) => new DateTimeOffset(
                    2024,
                    2,
                    29,
                    23,
                    59,
                    59,
                    TimeSpan.FromHours(3)
                ),
                _ when type == typeof(Guid) => Guid.Parse(
                    "8f2a5c1e-3b7d-4e9a-a1c2-6d4b8e0f2a37"
                ),
                { IsEnum: true } => Enum.GetValues(type).GetValue(1)!,
                { IsGenericType: true }
                    when type.GetGenericTypeDefinition() == typeof(IEnumerable<>) =>
                    SampleArray(type.GetGenericArguments()[0], depth),
                { IsGenericType: true }
                    when type.GetGenericTypeDefinition() == typeof(OneOf<,>) =>
                    type.GetMethod("FromT1")!
                        .Invoke(
                            null,
                            [Sample(type.GetGenericArguments()[1], depth + 1)]
                        )!,
                _ when IsUnion(type) => Construct(type.GetConstructors()[0], depth),
                _ => Construct(
                    type.GetConstructors()
                        .OrderByDescending(c => c.GetParameters().Length)
                        .First(),
                    depth
                ),
            };
    }

    private static Array SampleArray(Type element, int depth)
    {
        Array array = Array.CreateInstance(element, 1);
        array.SetValue(Sample(element, depth + 1), 0);
        return array;
    }

    private static object Construct(ConstructorInfo constructor, int depth)
    {
        return constructor.Invoke([
            .. constructor
                .GetParameters()
                .Select(parameter => Sample(parameter.ParameterType, depth + 1)),
        ]);
    }

    [Fact]
    public void UnionsWrapEachCaseAtItsIndex()
    {
        Type[] unions = [.. ModelTypes.Where(IsUnion)];
        Assert.NotEmpty(unions);
        foreach (Type union in unions)
        {
            Type[] cases = union.BaseType!.GetGenericArguments();
            ConstructorInfo[] constructors = union.GetConstructors();
            Assert.Equal(cases.Length, constructors.Length);
            foreach (ConstructorInfo constructor in constructors)
            {
                Type caseType = constructor.GetParameters().Single().ParameterType;
                object value = Sample(caseType, 0);
                IOneOf instance = (IOneOf)constructor.Invoke([value]);
                Assert.Equal(Array.IndexOf(cases, caseType), instance.Index);
                Assert.Same(value, instance.Value);
            }
        }
    }

    [Fact]
    public void RecordsKeepTheirConstructorArguments()
    {
        Type[] records =
        [
            .. ModelTypes.Where(type =>
                !IsUnion(type) && type.GetConstructors().Length > 0
            ),
        ];
        Assert.NotEmpty(records);
        foreach (Type record in records)
        {
            foreach (ConstructorInfo constructor in record.GetConstructors())
            {
                ParameterInfo[] parameters = constructor.GetParameters();
                object[] arguments =
                [
                    .. parameters.Select(parameter => Sample(parameter.ParameterType, 0)),
                ];
                object instance = constructor.Invoke(arguments);
                for (int i = 0; i < parameters.Length; i++)
                {
                    PropertyInfo? property = record.GetProperty(
                        parameters[i].Name!,
                        BindingFlags.Public
                            | BindingFlags.Instance
                            | BindingFlags.IgnoreCase
                    );
                    Assert.True(
                        property is not null,
                        $"{record.Name} has no property for {parameters[i].Name}"
                    );
                    Assert.Equal(arguments[i], property.GetValue(instance));
                }
            }
        }
    }

    [Fact]
    public void ShortQueryConstructorsLeaveOptionalClausesEmpty()
    {
        Type[] queries =
        [
            typeof(MainPlainQuery),
            typeof(MainGroupedQuery),
            typeof(PlainQuery),
            typeof(GroupedQuery),
        ];
        foreach (Type query in queries)
        {
            ConstructorInfo shortest = query
                .GetConstructors()
                .OrderBy(c => c.GetParameters().Length)
                .First();
            object instance = Construct(shortest, 0);
            string[] required =
            [
                .. shortest.GetParameters().Select(parameter => parameter.Name!),
            ];
            foreach (PropertyInfo property in query.GetProperties())
            {
                if (required.Contains(property.Name, StringComparer.OrdinalIgnoreCase))
                {
                    Assert.NotNull(property.GetValue(instance));
                }
                else if (property.PropertyType == typeof(bool))
                {
                    Assert.False((bool)property.GetValue(instance)!);
                }
                else
                {
                    Assert.Null(property.GetValue(instance));
                }
            }
        }
    }

    [Fact]
    public void TypesNameTheirSchemaType()
    {
        IType[] types =
        [
            .. ModelTypes
                .Where(type => typeof(IType).IsAssignableFrom(type))
                .Select(type => (IType)Activator.CreateInstance(type)!),
        ];
        Assert.Equal(24, types.Length);
        foreach (IType type in types)
        {
            string declared = type.GetType().Name["Type".Length..];
            string name = declared.Replace("Nullable", "");
            Assert.Equal(char.ToLowerInvariant(name[0]) + name[1..], type.Name);
            Assert.Equal(
                declared.EndsWith("Nullable", StringComparison.Ordinal),
                type.Nullable
            );
        }
    }

    [Fact]
    public void LeavesDeclareTheTypeInTheirName()
    {
        Type[] leaves =
        [
            .. ModelTypes.Where(type =>
                TypedInterfaces.Any(i => i.IsAssignableFrom(type))
            ),
        ];
        Assert.NotEmpty(leaves);
        foreach (Type leaf in leaves)
        {
            object instance = Sample(leaf, 0);
            IType type = (IType)leaf.GetProperty("Type")!.GetValue(instance)!;
            string declared = type.GetType().Name["Type".Length..].Replace("List", "");
            Assert.True(
                leaf.Name.EndsWith(declared, StringComparison.Ordinal),
                $"{leaf.Name} declares {type.GetType().Name}"
            );
        }
    }

    [Theory]
    [InlineData(false, "TypeDecimal")]
    [InlineData(true, "TypeDecimalNullable")]
    public void SubqueryColumnsFollowTheirNullability(bool nullable, string expected)
    {
        ListSubqueryColumnDecimal column = new ListSubqueryColumnDecimal(
            "totals",
            "total",
            nullable
        );
        Assert.Equal(expected, column.Type.GetType().Name);
        Assert.Equal(nullable, column.Type.Nullable);
    }
}
