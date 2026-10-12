using PureQL.CSharp.Model.TotalExpressions;
using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.SelectItems;

public sealed record SelectItemTotalDecimalNullable : ISelectItem
{
    public SelectItemTotalDecimalNullable(
        string alias,
        ExactDecimalNullableTotal expression
    )
    {
        Alias = alias;
        Expression = expression;
    }

    public string Alias { get; }

    public ExactDecimalNullableTotal Expression { get; }

    public IType Type => new TypeDecimalNullable();
}
