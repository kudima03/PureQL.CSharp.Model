using PureQL.CSharp.Model.ProjectionExpressions;

namespace PureQL.CSharp.Model;

/// <summary>PureQL <c>orderItem@projection</c>.</summary>
public sealed record OrderItemProjection
{
    public OrderItemProjection(
        ExprProjection expression,
        SortDirection direction = SortDirection.Asc
    )
    {
        Expression = expression;
        Direction = direction;
    }

    public ExprProjection Expression { get; }

    public SortDirection Direction { get; }
}
