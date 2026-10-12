using PureQL.CSharp.Model.TotalExpressions;
using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.SelectItems;

public sealed record SelectItemTotalStringNullable : ISelectItem
{
    public SelectItemTotalStringNullable(
        string alias,
        ExactStringNullableTotal expression
    )
    {
        Alias = alias;
        Expression = expression;
    }

    public string Alias { get; }

    public ExactStringNullableTotal Expression { get; }

    public IType Type => new TypeStringNullable();
}
