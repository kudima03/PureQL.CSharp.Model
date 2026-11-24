using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.TotalExpressions;

/// <summary>PureQL <c>greatest.uuid.nullable@total</c>.</summary>
public sealed record GreatestUuidNullableTotal : IOperator
{
    public GreatestUuidNullableTotal(IEnumerable<UuidNullableTotal> values)
    {
        Values = values;
    }

    public IEnumerable<UuidNullableTotal> Values { get; }

    public IType Type => new TypeUuidNullable();
}
