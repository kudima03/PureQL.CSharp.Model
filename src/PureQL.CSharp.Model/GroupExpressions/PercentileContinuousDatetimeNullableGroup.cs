using PureQL.CSharp.Model.RowExpressions;
using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.GroupExpressions;

/// <summary>PureQL <c>percentileContinuous.datetime.nullable@group</c>.</summary>
public sealed record PercentileContinuousDatetimeNullableGroup : IOperator
{
    public PercentileContinuousDatetimeNullableGroup(
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
