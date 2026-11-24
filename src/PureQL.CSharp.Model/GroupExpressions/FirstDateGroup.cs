using PureQL.CSharp.Model.RowExpressions;
using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.GroupExpressions;

/// <summary>PureQL <c>first.date@group</c>.</summary>
public sealed record FirstDateGroup : IOperator
{
    public FirstDateGroup(
        DateRow selector,
        IEnumerable<OrderItemRow> orderBy,
        AggregateOver over = AggregateOver.Group
    )
    {
        Over = over;
        Selector = selector;
        OrderBy = orderBy;
    }

    public AggregateOver Over { get; }

    public DateRow Selector { get; }

    public IEnumerable<OrderItemRow> OrderBy { get; }

    public IType Type => new TypeDate();
}
