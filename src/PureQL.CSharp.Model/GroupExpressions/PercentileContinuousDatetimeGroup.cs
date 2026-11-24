using PureQL.CSharp.Model.RowExpressions;
using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.GroupExpressions;

/// <summary>PureQL <c>percentileContinuous.datetime@group</c>.</summary>
public sealed record PercentileContinuousDatetimeGroup : IOperator
{
    public PercentileContinuousDatetimeGroup(
        DatetimeRow selector,
        Fraction fraction,
        AggregateOver over = AggregateOver.Group
    )
    {
        Over = over;
        Selector = selector;
        Fraction = fraction;
    }

    public AggregateOver Over { get; }

    public DatetimeRow Selector { get; }

    public Fraction Fraction { get; }

    public IType Type => new TypeDatetime();
}
