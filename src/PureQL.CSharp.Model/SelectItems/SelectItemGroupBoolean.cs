using PureQL.CSharp.Model.GroupExpressions;
using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.SelectItems;

public sealed record SelectItemGroupBoolean : ISelectItem
{
    public SelectItemGroupBoolean(string alias, BooleanGroup expression)
    {
        Alias = alias;
        Expression = expression;
    }

    public string Alias { get; }

    public BooleanGroup Expression { get; }

    public IType Type => new TypeBoolean();
}
