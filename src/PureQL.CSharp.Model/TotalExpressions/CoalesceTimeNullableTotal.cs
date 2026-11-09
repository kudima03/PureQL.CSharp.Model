using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.TotalExpressions;

/// <summary>PureQL <c>coalesce.time.nullable@total</c>.</summary>
public sealed record CoalesceTimeNullableTotal : IOperator
{
    public CoalesceTimeNullableTotal(IEnumerable<DeclaresTimeNullableTotal> values)
    {
        Values = values;
    }

    public IEnumerable<DeclaresTimeNullableTotal> Values { get; }

    public IType Type => new TypeTimeNullable();
}
