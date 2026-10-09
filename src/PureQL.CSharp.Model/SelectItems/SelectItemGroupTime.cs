using PureQL.CSharp.Model.GroupExpressions;
using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.SelectItems;

public sealed record SelectItemGroupTime : ISelectItem
{
    public SelectItemGroupTime(string alias, TimeGroup expression)
    {
        Alias = alias;
        Expression = expression;
    }

    public string Alias { get; }

    public TimeGroup Expression { get; }

    public IType Type => new TypeTime();
}
