using PureQL.CSharp.Model.RowExpressions;
using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.GroupExpressions;

/// <summary>PureQL <c>percentileDiscrete.time@group</c>.</summary>
public sealed record PercentileDiscreteTimeGroup : IOperator
{
    public PercentileDiscreteTimeGroup(
        TimeRow selector,
        Fraction fraction,
        AggregateOver over = AggregateOver.Group
    )
    {
        Over = over;
        Selector = selector;
        Fraction = fraction;
    }

    public AggregateOver Over { get; }

    public TimeRow Selector { get; }

    public Fraction Fraction { get; }

    public IType Type => new TypeTime();
}
