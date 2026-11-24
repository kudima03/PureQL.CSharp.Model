using PureQL.CSharp.Model.RowExpressions;

namespace PureQL.CSharp.Model;

/// <summary>PureQL <c>orderItem.integer@row</c>.</summary>
public sealed record OrderItemIntegerRow
{
    public OrderItemIntegerRow(
        IntegerNullableRow expression,
        SortDirection direction = SortDirection.Asc
    )
    {
        Expression = expression;
        Direction = direction;
    }

    public IntegerNullableRow Expression { get; }

    public SortDirection Direction { get; }
}
