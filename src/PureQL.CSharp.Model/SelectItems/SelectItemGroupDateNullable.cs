using PureQL.CSharp.Model.GroupExpressions;
using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.SelectItems;

public sealed record SelectItemGroupDateNullable : ISelectItem
{
    public SelectItemGroupDateNullable(string alias, DateNullableGroup expression)
    {
        Alias = alias;
        Expression = expression;
    }

    public string Alias { get; }

    public DateNullableGroup Expression { get; }

    public IType Type => new TypeDateNullable();
}
