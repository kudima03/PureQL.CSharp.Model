namespace PureQL.CSharp.Model;

public sealed record OrderItemGroupColumn
{
    public OrderItemGroupColumn(
        string column,
        SortDirection direction = SortDirection.Asc
    )
    {
        Column = column;
        Direction = direction;
    }

    public string Column { get; }

    public SortDirection Direction { get; }
}
