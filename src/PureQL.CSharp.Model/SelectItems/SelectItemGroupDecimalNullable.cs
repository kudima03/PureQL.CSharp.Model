using PureQL.CSharp.Model.GroupExpressions;
using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.SelectItems;

public sealed record SelectItemGroupDecimalNullable : ISelectItem
{
    public SelectItemGroupDecimalNullable(
        string alias,
        ExactDecimalNullableGroup expression
    )
    {
        Alias = alias;
        Expression = expression;
    }

    public string Alias { get; }

    public ExactDecimalNullableGroup Expression { get; }

    public IType Type => new TypeDecimalNullable();
}
