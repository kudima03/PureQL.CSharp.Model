using PureQL.CSharp.Model.RowExpressions;
using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.GroupExpressions;

/// <summary>PureQL <c>percentileDiscrete.integer@group</c>.</summary>
public sealed record PercentileDiscreteIntegerGroup : IOperator
{
    public PercentileDiscreteIntegerGroup(
        IntegerRow selector,
        Fraction fraction,
        AggregateOver over = AggregateOver.Group
    )
    {
        Over = over;
        Selector = selector;
        Fraction = fraction;
    }

    public AggregateOver Over { get; }

    public IntegerRow Selector { get; }

    public Fraction Fraction { get; }

    public IType Type => new TypeInteger();
}
