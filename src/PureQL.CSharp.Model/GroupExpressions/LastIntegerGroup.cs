using PureQL.CSharp.Model.RowExpressions;
using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.GroupExpressions;

/// <summary>PureQL <c>last.integer@group</c>.</summary>
public sealed record LastIntegerGroup : IOperator
{
    public LastIntegerGroup(
        IntegerRow selector,
        IEnumerable<OrderItemRow> orderBy,
        AggregateOver over = AggregateOver.Group
    )
    {
        Over = over;
        Selector = selector;
        OrderBy = orderBy;
    }

    public AggregateOver Over { get; }

    public IntegerRow Selector { get; }

    public IEnumerable<OrderItemRow> OrderBy { get; }

    public IType Type => new TypeInteger();
}
