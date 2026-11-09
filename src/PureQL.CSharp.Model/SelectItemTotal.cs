using PureQL.CSharp.Model.TotalExpressions;

namespace PureQL.CSharp.Model;

/// <summary>PureQL <c>selectItem@total</c>.</summary>
public sealed record SelectItemTotal
{
    public SelectItemTotal(string alias, ExprTotal expression)
    {
        Alias = alias;
        Expression = expression;
    }

    public string Alias { get; }

    public ExprTotal Expression { get; }
}
