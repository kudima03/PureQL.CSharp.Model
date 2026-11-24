using PureQL.CSharp.Model.RowExpressions;
using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.ProjectionExpressions;

/// <summary>PureQL <c>last.date@projection</c>.</summary>
public sealed record LastDateProjection : IOperator
{
    public LastDateProjection(
        DateRow selector,
        IEnumerable<OrderItemRow> orderBy,
        Window? over = null
    )
    {
        Over = over;
        Selector = selector;
        OrderBy = orderBy;
    }

    public Window? Over { get; }

    public DateRow Selector { get; }

    public IEnumerable<OrderItemRow> OrderBy { get; }

    public IType Type => new TypeDate();
}
