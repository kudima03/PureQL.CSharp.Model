using PureQL.CSharp.Model.GroupExpressions;
using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.SelectItems;

public sealed record SelectItemGroupBooleanNullable : ISelectItem
{
    public SelectItemGroupBooleanNullable(string alias, BooleanNullableGroup expression)
    {
        Alias = alias;
        Expression = expression;
    }

    public string Alias { get; }

    public BooleanNullableGroup Expression { get; }

    public IType Type => new TypeBooleanNullable();
}
