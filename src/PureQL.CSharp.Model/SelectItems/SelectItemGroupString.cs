using PureQL.CSharp.Model.GroupExpressions;
using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.SelectItems;

public sealed record SelectItemGroupString : ISelectItem
{
    public SelectItemGroupString(string alias, StringGroup expression)
    {
        Alias = alias;
        Expression = expression;
    }

    public string Alias { get; }

    public StringGroup Expression { get; }

    public IType Type => new TypeString();
}
