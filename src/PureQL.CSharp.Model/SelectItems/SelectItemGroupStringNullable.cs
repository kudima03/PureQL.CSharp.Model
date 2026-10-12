using PureQL.CSharp.Model.GroupExpressions;
using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.SelectItems;

public sealed record SelectItemGroupStringNullable : ISelectItem
{
    public SelectItemGroupStringNullable(
        string alias,
        ExactStringNullableGroup expression
    )
    {
        Alias = alias;
        Expression = expression;
    }

    public string Alias { get; }

    public ExactStringNullableGroup Expression { get; }

    public IType Type => new TypeStringNullable();
}
