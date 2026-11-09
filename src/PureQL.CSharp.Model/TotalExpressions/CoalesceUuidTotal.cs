using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.TotalExpressions;

/// <summary>PureQL <c>coalesce.uuid@total</c>.</summary>
public sealed record CoalesceUuidTotal : IOperator
{
    public CoalesceUuidTotal(IEnumerable<UuidNullableTotal> values)
    {
        Values = values;
    }

    public IEnumerable<UuidNullableTotal> Values { get; }

    public IType Type => new TypeUuid();
}
