using PureQL.CSharp.Model.RowExpressions;

namespace PureQL.CSharp.Model.GroupExpressions;

public sealed record CountGroup
{
    public CountGroup(
        BooleanRow? predicate = null,
        AggregateOver over = AggregateOver.Group
    )
    {
        Predicate = predicate;
        Over = over;
    }

    public BooleanRow? Predicate { get; }

    public AggregateOver Over { get; }
}
