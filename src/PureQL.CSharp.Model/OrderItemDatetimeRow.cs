using PureQL.CSharp.Model.RowExpressions;

namespace PureQL.CSharp.Model;

/// <summary>PureQL <c>orderItem.datetime@row</c>.</summary>
public sealed record OrderItemDatetimeRow
{
    public OrderItemDatetimeRow(
        DatetimeNullableRow expression,
        SortDirection direction = SortDirection.Asc
    )
    {
        Expression = expression;
        Direction = direction;
    }

    public DatetimeNullableRow Expression { get; }

    public SortDirection Direction { get; }
}
