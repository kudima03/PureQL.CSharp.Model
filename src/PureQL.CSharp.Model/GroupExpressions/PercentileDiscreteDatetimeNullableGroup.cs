using PureQL.CSharp.Model.RowExpressions;
using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.GroupExpressions;

/// <summary>PureQL <c>percentileDiscrete.datetime.nullable@group</c>.</summary>
public sealed record PercentileDiscreteDatetimeNullableGroup : IOperator
{
    public PercentileDiscreteDatetimeNullableGroup(
        DatetimeNullableRow selector,
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

    public DatetimeNullableRow Selector { get; }

    public Fraction Fraction { get; }

    public IType Type => new TypeDatetimeNullable();
}
