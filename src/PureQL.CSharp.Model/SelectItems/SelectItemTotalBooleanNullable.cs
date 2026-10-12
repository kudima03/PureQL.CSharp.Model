using PureQL.CSharp.Model.TotalExpressions;
using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.SelectItems;

public sealed record SelectItemTotalBooleanNullable : ISelectItem
{
    public SelectItemTotalBooleanNullable(
        string alias,
        ExactBooleanNullableTotal expression
    )
    {
        Alias = alias;
        Expression = expression;
    }

    public string Alias { get; }

    public ExactBooleanNullableTotal Expression { get; }

    public IType Type => new TypeBooleanNullable();
}
