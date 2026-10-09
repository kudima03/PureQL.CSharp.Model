using PureQL.CSharp.Model.GroupExpressions;
using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.SelectItems;

public sealed record SelectItemGroupTimeNullable : ISelectItem
{
    public SelectItemGroupTimeNullable(string alias, TimeNullableGroup expression)
    {
        Alias = alias;
        Expression = expression;
    }

    public string Alias { get; }

    public TimeNullableGroup Expression { get; }

    public IType Type => new TypeTimeNullable();
}
