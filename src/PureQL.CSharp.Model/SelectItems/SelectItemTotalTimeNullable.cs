using PureQL.CSharp.Model.TotalExpressions;
using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.SelectItems;

public sealed record SelectItemTotalTimeNullable : ISelectItem
{
    public SelectItemTotalTimeNullable(string alias, ExactTimeNullableTotal expression)
    {
        Alias = alias;
        Expression = expression;
    }

    public string Alias { get; }

    public ExactTimeNullableTotal Expression { get; }

    public IType Type => new TypeTimeNullable();
}
