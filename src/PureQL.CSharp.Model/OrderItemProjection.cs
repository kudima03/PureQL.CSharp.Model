using PureQL.CSharp.Model.ProjectionExpressions;

namespace PureQL.CSharp.Model;

public sealed record OrderItemProjection
{
    public OrderItemProjection(
        ValueProjection expression,
        SortDirection direction = SortDirection.Asc
    )
    {
        Expression = expression;
        Direction = direction;
    }

    public ValueProjection Expression { get; }

    public SortDirection Direction { get; }
}
