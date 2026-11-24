using PureQL.CSharp.Model.RowExpressions;
using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.GroupExpressions;

/// <summary>PureQL <c>percentileDiscrete.boolean@group</c>.</summary>
public sealed record PercentileDiscreteBooleanGroup : IOperator
{
    public PercentileDiscreteBooleanGroup(
        BooleanRow selector,
        Fraction fraction,
        AggregateOver over = AggregateOver.Group
    )
    {
        Over = over;
        Selector = selector;
        Fraction = fraction;
    }

    public AggregateOver Over { get; }

    public BooleanRow Selector { get; }

    public Fraction Fraction { get; }

    public IType Type => new TypeBoolean();
}
