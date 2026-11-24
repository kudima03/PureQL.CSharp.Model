using PureQL.CSharp.Model.RowExpressions;
using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.GroupExpressions;

/// <summary>PureQL <c>percentileDiscrete.uuid@group</c>.</summary>
public sealed record PercentileDiscreteUuidGroup : IOperator
{
    public PercentileDiscreteUuidGroup(
        UuidRow selector,
        Fraction fraction,
        AggregateOver over = AggregateOver.Group
    )
    {
        Over = over;
        Selector = selector;
        Fraction = fraction;
    }

    public AggregateOver Over { get; }

    public UuidRow Selector { get; }

    public Fraction Fraction { get; }

    public IType Type => new TypeUuid();
}
