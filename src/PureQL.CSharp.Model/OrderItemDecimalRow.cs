using PureQL.CSharp.Model.RowExpressions;

namespace PureQL.CSharp.Model;

/// <summary>PureQL <c>orderItem.decimal@row</c>.</summary>
public sealed record OrderItemDecimalRow
{
    public OrderItemDecimalRow(
        DecimalOrDecimalNullableRow expression,
        SortDirection direction = SortDirection.Asc
    )
    {
        Expression = expression;
        Direction = direction;
    }

    public DecimalOrDecimalNullableRow Expression { get; }

    public SortDirection Direction { get; }
}
