using PureQL.CSharp.Model.RowExpressions;
using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.GroupExpressions;

/// <summary>PureQL <c>percentileDiscrete.time.nullable@group</c>.</summary>
public sealed record PercentileDiscreteTimeNullableGroup : IOperator
{
    public PercentileDiscreteTimeNullableGroup(
        TimeNullableRow selector,
        Fraction fraction,
        BooleanRow? predicate = null,
        AggregateOver over = AggregateOver.Group
    )
    {
        Predicate = predicate;
        Over = over;
        Selector = selector;
        Fraction = fraction;
    }

    public BooleanRow? Predicate { get; }

    public AggregateOver Over { get; }

    public TimeNullableRow Selector { get; }

    public Fraction Fraction { get; }

    public IType Type => new TypeTimeNullable();
}
