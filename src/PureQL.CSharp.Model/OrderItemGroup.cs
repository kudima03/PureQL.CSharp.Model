using PureQL.CSharp.Model.GroupExpressions;

namespace PureQL.CSharp.Model;

public sealed record OrderItemGroup
{
    public OrderItemGroup(
        ExprGroup expression,
        SortDirection direction = SortDirection.Asc
    )
    {
        Expression = expression;
        Direction = direction;
    }

    public ExprGroup Expression { get; }

    public SortDirection Direction { get; }
}
