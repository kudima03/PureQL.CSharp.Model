using PureQL.CSharp.Model.RowExpressions;
using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.ProjectionExpressions;

/// <summary>PureQL <c>last.datetime@projection</c>.</summary>
public sealed record LastDatetimeProjection : IOperator
{
    public LastDatetimeProjection(
        DatetimeRow selector,
        IEnumerable<OrderItemRow> orderBy,
        Window? over = null
    )
    {
        Over = over;
        Selector = selector;
        OrderBy = orderBy;
    }

    public Window? Over { get; }

    public DatetimeRow Selector { get; }

    public IEnumerable<OrderItemRow> OrderBy { get; }

    public IType Type => new TypeDatetime();
}
