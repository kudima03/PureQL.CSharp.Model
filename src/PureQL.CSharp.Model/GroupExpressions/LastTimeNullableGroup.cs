using PureQL.CSharp.Model.RowExpressions;
using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.GroupExpressions;

/// <summary>PureQL <c>last.time.nullable@group</c>.</summary>
public sealed record LastTimeNullableGroup : IOperator
{
    public LastTimeNullableGroup(
        TimeNullableRow selector,
        IEnumerable<OrderItemRow> orderBy,
        BooleanRow? predicate = null,
        AggregateOver over = AggregateOver.Group
    )
    {
        Predicate = predicate;
        Over = over;
        Selector = selector;
        OrderBy = orderBy;
    }

    public BooleanRow? Predicate { get; }

    public AggregateOver Over { get; }

    public TimeNullableRow Selector { get; }

    public IEnumerable<OrderItemRow> OrderBy { get; }

    public IType Type => new TypeTimeNullable();
}
