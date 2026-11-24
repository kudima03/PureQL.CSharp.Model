using PureQL.CSharp.Model.RowExpressions;
using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.GroupExpressions;

/// <summary>PureQL <c>last.string@group</c>.</summary>
public sealed record LastStringGroup : IOperator
{
    public LastStringGroup(
        StringRow selector,
        IEnumerable<OrderItemRow> orderBy,
        AggregateOver over = AggregateOver.Group
    )
    {
        Over = over;
        Selector = selector;
        OrderBy = orderBy;
    }

    public AggregateOver Over { get; }

    public StringRow Selector { get; }

    public IEnumerable<OrderItemRow> OrderBy { get; }

    public IType Type => new TypeString();
}
