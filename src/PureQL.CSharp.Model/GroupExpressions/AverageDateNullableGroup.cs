using PureQL.CSharp.Model.RowExpressions;

namespace PureQL.CSharp.Model.GroupExpressions;

public sealed record AverageDateNullableGroup
{
    public AverageDateNullableGroup(
        DateNullableRow selector,
        BooleanRow? predicate = null,
        AggregateOver over = AggregateOver.Group
    )
    {
        Selector = selector;
        Predicate = predicate;
        Over = over;
    }

    public DateNullableRow Selector { get; }

    public BooleanRow? Predicate { get; }

    public AggregateOver Over { get; }
}
