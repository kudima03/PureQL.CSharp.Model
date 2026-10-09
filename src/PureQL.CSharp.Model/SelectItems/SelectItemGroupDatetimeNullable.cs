using PureQL.CSharp.Model.GroupExpressions;
using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.SelectItems;

public sealed record SelectItemGroupDatetimeNullable : ISelectItem
{
    public SelectItemGroupDatetimeNullable(string alias, DatetimeNullableGroup expression)
    {
        Alias = alias;
        Expression = expression;
    }

    public string Alias { get; }

    public DatetimeNullableGroup Expression { get; }

    public IType Type => new TypeDatetimeNullable();
}
