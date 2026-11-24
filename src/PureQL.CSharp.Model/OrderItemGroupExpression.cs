using PureQL.CSharp.Model.GroupExpressions;

namespace PureQL.CSharp.Model;

public sealed record OrderItemGroupExpression
{
    public OrderItemGroupExpression(
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
