using PureQL.CSharp.Model.GroupExpressions;
using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.SelectItems;

public sealed record SelectItemGroupDatetimeNullable : ISelectItem
{
    public SelectItemGroupDatetimeNullable(
        string alias,
        ExactDatetimeNullableGroup expression
    )
    {
        Alias = alias;
        Expression = expression;
    }

    public string Alias { get; }

    public ExactDatetimeNullableGroup Expression { get; }

    public IType Type => new TypeDatetimeNullable();
}
