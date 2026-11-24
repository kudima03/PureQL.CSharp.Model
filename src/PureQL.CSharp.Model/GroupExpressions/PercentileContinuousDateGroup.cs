using PureQL.CSharp.Model.RowExpressions;
using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.GroupExpressions;

/// <summary>PureQL <c>percentileContinuous.date@group</c>.</summary>
public sealed record PercentileContinuousDateGroup : IOperator
{
    public PercentileContinuousDateGroup(
        DateRow selector,
        Fraction fraction,
        AggregateOver over = AggregateOver.Group
    )
    {
        Over = over;
        Selector = selector;
        Fraction = fraction;
    }

    public AggregateOver Over { get; }

    public DateRow Selector { get; }

    public Fraction Fraction { get; }

    public IType Type => new TypeDate();
}
