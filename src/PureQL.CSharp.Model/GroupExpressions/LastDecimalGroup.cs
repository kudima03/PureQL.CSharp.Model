using PureQL.CSharp.Model.RowExpressions;
using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.GroupExpressions;

/// <summary>PureQL <c>last.decimal@group</c>.</summary>
public sealed record LastDecimalGroup : IOperator
{
    public LastDecimalGroup(
        DeclaresDecimalRow selector,
        IEnumerable<OrderItemRow> orderBy,
        AggregateOver over = AggregateOver.Group
    )
    {
        Over = over;
        Selector = selector;
        OrderBy = orderBy;
    }

    public AggregateOver Over { get; }

    public DeclaresDecimalRow Selector { get; }

    public IEnumerable<OrderItemRow> OrderBy { get; }

    public IType Type => new TypeDecimal();
}
