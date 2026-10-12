using PureQL.CSharp.Model.TotalExpressions;
using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.SelectItems;

public sealed record SelectItemTotalTime : ISelectItem
{
    public SelectItemTotalTime(string alias, TimeTotal expression)
    {
        Alias = alias;
        Expression = expression;
    }

    public string Alias { get; }

    public TimeTotal Expression { get; }

    public IType Type => new TypeTime();
}
