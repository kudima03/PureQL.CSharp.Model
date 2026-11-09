using PureQL.CSharp.Model.ProjectionExpressions;

namespace PureQL.CSharp.Model;

/// <summary>PureQL <c>selectItem@projection</c>.</summary>
public sealed record SelectItemProjection
{
    public SelectItemProjection(string alias, ExprProjection expression)
    {
        Alias = alias;
        Expression = expression;
    }

    public string Alias { get; }

    public ExprProjection Expression { get; }
}
