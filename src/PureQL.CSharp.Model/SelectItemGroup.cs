using PureQL.CSharp.Model.GroupExpressions;

namespace PureQL.CSharp.Model;

/// <summary>PureQL <c>selectItem@group</c>.</summary>
public sealed record SelectItemGroup
{
    public SelectItemGroup(string alias, ExprGroup expression)
    {
        Alias = alias;
        Expression = expression;
    }

    public string Alias { get; }

    public ExprGroup Expression { get; }
}
