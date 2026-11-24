using PureQL.CSharp.Model.RowExpressions;

namespace PureQL.CSharp.Model;

/// <summary>PureQL <c>orderItem.date@row</c>.</summary>
public sealed record OrderItemDateRow
{
    public OrderItemDateRow(
        DateNullableRow expression,
        SortDirection direction = SortDirection.Asc
    )
    {
        Expression = expression;
        Direction = direction;
    }

    public DateNullableRow Expression { get; }

    public SortDirection Direction { get; }
}
