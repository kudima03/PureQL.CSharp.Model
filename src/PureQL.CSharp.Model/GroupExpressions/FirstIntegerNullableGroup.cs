using PureQL.CSharp.Model.RowExpressions;
using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.GroupExpressions;

/// <summary>PureQL <c>first.integer.nullable@group</c>.</summary>
public sealed record FirstIntegerNullableGroup : IOperator
{
    public FirstIntegerNullableGroup(
        IntegerNullableRow selector,
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

    public IntegerNullableRow Selector { get; }

    public IEnumerable<OrderItemRow> OrderBy { get; }

    public IType Type => new TypeIntegerNullable();
}
