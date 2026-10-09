using PureQL.CSharp.Model.RowExpressions;

namespace PureQL.CSharp.Model.GroupExpressions;

public sealed record SumIntegerGroup
{
    public SumIntegerGroup(
        IntegerNullableRow selector,
        BooleanRow? predicate = null,
        AggregateOver over = AggregateOver.Group
    )
    {
        Selector = selector;
        Predicate = predicate;
        Over = over;
    }

    public IntegerNullableRow Selector { get; }

    public BooleanRow? Predicate { get; }

    public AggregateOver Over { get; }
}
