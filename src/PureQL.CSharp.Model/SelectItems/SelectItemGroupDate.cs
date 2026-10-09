using PureQL.CSharp.Model.GroupExpressions;
using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.SelectItems;

public sealed record SelectItemGroupDate : ISelectItem
{
    public SelectItemGroupDate(string alias, DateGroup expression)
    {
        Alias = alias;
        Expression = expression;
    }

    public string Alias { get; }

    public DateGroup Expression { get; }

    public IType Type => new TypeDate();
}
