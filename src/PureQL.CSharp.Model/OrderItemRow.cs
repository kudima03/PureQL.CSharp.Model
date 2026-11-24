using PureQL.CSharp.Model.RowExpressions;

namespace PureQL.CSharp.Model;

/// <summary>PureQL <c>orderItem@row</c>.</summary>
public sealed record OrderItemRow
{
    public OrderItemRow(ExprRow expression, SortDirection direction = SortDirection.Asc)
    {
        Expression = expression;
        Direction = direction;
    }

    public ExprRow Expression { get; }

    public SortDirection Direction { get; }
}
