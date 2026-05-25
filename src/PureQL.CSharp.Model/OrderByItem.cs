using PureQL.CSharp.Model.Fields;

namespace PureQL.CSharp.Model;

public sealed record OrderByItem
{
    public OrderByItem(Field field, SortDirection direction = SortDirection.Asc)
    {
        Field = field;
        Direction = direction;
    }

    public Field Field { get; }

    public SortDirection Direction { get; }
}
