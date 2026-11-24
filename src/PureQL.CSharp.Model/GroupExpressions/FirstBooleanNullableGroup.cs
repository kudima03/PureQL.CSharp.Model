using PureQL.CSharp.Model.RowExpressions;
using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.GroupExpressions;

/// <summary>PureQL <c>first.boolean.nullable@group</c>.</summary>
public sealed record FirstBooleanNullableGroup : IOperator
{
    public FirstBooleanNullableGroup(
        BooleanNullableRow selector,
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

    public BooleanNullableRow Selector { get; }

    public IEnumerable<OrderItemRow> OrderBy { get; }

    public IType Type => new TypeBooleanNullable();
}
