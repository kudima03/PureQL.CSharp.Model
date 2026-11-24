using PureQL.CSharp.Model.RowExpressions;
using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.GroupExpressions;

/// <summary>PureQL <c>last.datetime@group</c>.</summary>
public sealed record LastDatetimeGroup : IOperator
{
    public LastDatetimeGroup(
        DatetimeRow selector,
        IEnumerable<OrderItemRow> orderBy,
        AggregateOver over = AggregateOver.Group
    )
    {
        Over = over;
        Selector = selector;
        OrderBy = orderBy;
    }

    public AggregateOver Over { get; }

    public DatetimeRow Selector { get; }

    public IEnumerable<OrderItemRow> OrderBy { get; }

    public IType Type => new TypeDatetime();
}
