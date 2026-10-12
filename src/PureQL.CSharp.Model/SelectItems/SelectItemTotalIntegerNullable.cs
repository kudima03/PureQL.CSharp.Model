using PureQL.CSharp.Model.TotalExpressions;
using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.SelectItems;

public sealed record SelectItemTotalIntegerNullable : ISelectItem
{
    public SelectItemTotalIntegerNullable(
        string alias,
        ExactIntegerNullableTotal expression
    )
    {
        Alias = alias;
        Expression = expression;
    }

    public string Alias { get; }

    public ExactIntegerNullableTotal Expression { get; }

    public IType Type => new TypeIntegerNullable();
}
