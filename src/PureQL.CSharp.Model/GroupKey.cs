using PureQL.CSharp.Model.RowExpressions;

namespace PureQL.CSharp.Model;

/// <summary>PureQL <c>groupKey</c>.</summary>
public sealed record GroupKey
{
    public GroupKey(string alias, ExprRow expression)
    {
        Alias = alias;
        Expression = expression;
    }

    public string Alias { get; }

    public ExprRow Expression { get; }
}
