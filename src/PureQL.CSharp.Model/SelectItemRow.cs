using PureQL.CSharp.Model.RowExpressions;

namespace PureQL.CSharp.Model;

/// <summary>PureQL <c>selectItem@row</c>.</summary>
public sealed record SelectItemRow
{
    public SelectItemRow(string alias, ExprRow expression)
    {
        Alias = alias;
        Expression = expression;
    }

    public string Alias { get; }

    public ExprRow Expression { get; }
}
