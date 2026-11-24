using PureQL.CSharp.Model.RowExpressions;
using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.GroupExpressions;

/// <summary>PureQL <c>percentileContinuous.time.nullable@group</c>.</summary>
public sealed record PercentileContinuousTimeNullableGroup : IOperator
{
    public PercentileContinuousTimeNullableGroup(
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
