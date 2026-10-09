using PureQL.CSharp.Model.GroupExpressions;
using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.SelectItems;

public sealed record SelectItemGroupStringNullable : ISelectItem
{
    public SelectItemGroupStringNullable(string alias, StringNullableGroup expression)
    {
        Alias = alias;
        Expression = expression;
    }

    public string Alias { get; }

    public StringNullableGroup Expression { get; }

    public IType Type => new TypeStringNullable();
}
