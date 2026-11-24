using PureQL.CSharp.Model.RowExpressions;
using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.GroupExpressions;

/// <summary>PureQL <c>percentileDiscrete.string@group</c>.</summary>
public sealed record PercentileDiscreteStringGroup : IOperator
{
    public PercentileDiscreteStringGroup(
        StringRow selector,
        Fraction fraction,
        AggregateOver over = AggregateOver.Group
    )
    {
        Over = over;
        Selector = selector;
        Fraction = fraction;
    }

    public AggregateOver Over { get; }

    public StringRow Selector { get; }

    public Fraction Fraction { get; }

    public IType Type => new TypeString();
}
