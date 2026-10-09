using PureQL.CSharp.Model.GroupExpressions;
using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.SelectItems;

public sealed record SelectItemGroupIntegerNullable : ISelectItem
{
    public SelectItemGroupIntegerNullable(string alias, IntegerNullableGroup expression)
    {
        Alias = alias;
        Expression = expression;
    }

    public string Alias { get; }

    public IntegerNullableGroup Expression { get; }

    public IType Type => new TypeIntegerNullable();
}
