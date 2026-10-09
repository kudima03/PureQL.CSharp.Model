using PureQL.CSharp.Model.GroupExpressions;

namespace PureQL.CSharp.Model;

public sealed record OrderItemGroup
{
    public OrderItemGroup(
        ValueGroup expression,
        SortDirection direction = SortDirection.Asc
    )
    {
        Expression = expression;
        Direction = direction;
    }

    public ValueGroup Expression { get; }

    public SortDirection Direction { get; }
}
