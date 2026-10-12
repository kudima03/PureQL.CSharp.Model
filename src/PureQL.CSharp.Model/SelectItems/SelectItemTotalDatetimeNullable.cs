using PureQL.CSharp.Model.TotalExpressions;
using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.SelectItems;

public sealed record SelectItemTotalDatetimeNullable : ISelectItem
{
    public SelectItemTotalDatetimeNullable(
        string alias,
        ExactDatetimeNullableTotal expression
    )
    {
        Alias = alias;
        Expression = expression;
    }

    public string Alias { get; }

    public ExactDatetimeNullableTotal Expression { get; }

    public IType Type => new TypeDatetimeNullable();
}
