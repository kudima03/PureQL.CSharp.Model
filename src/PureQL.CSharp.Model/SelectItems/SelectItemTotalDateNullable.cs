using PureQL.CSharp.Model.TotalExpressions;
using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.SelectItems;

public sealed record SelectItemTotalDateNullable : ISelectItem
{
    public SelectItemTotalDateNullable(string alias, ExactDateNullableTotal expression)
    {
        Alias = alias;
        Expression = expression;
    }

    public string Alias { get; }

    public ExactDateNullableTotal Expression { get; }

    public IType Type => new TypeDateNullable();
}
