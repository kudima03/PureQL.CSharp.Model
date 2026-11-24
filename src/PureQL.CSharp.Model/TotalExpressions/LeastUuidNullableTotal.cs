using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.TotalExpressions;

/// <summary>PureQL <c>least.uuid.nullable@total</c>.</summary>
public sealed record LeastUuidNullableTotal : IOperator
{
    public LeastUuidNullableTotal(IEnumerable<UuidNullableTotal> values)
    {
        Values = values;
    }

    public IEnumerable<UuidNullableTotal> Values { get; }

    public IType Type => new TypeUuidNullable();
}
