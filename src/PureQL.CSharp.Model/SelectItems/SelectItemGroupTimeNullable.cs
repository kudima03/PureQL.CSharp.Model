using PureQL.CSharp.Model.GroupExpressions;
using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.SelectItems;

public sealed record SelectItemGroupTimeNullable : ISelectItem
{
    public SelectItemGroupTimeNullable(string alias, ExactTimeNullableGroup expression)
    {
        Alias = alias;
        Expression = expression;
    }

    public string Alias { get; }

    public ExactTimeNullableGroup Expression { get; }

    public IType Type => new TypeTimeNullable();
}
