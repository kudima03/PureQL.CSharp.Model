namespace PureQL.CSharp.Model;

public sealed record OrderItemProjectionColumn
{
    public OrderItemProjectionColumn(
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
