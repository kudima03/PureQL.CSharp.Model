using PureQL.CSharp.Model.TotalExpressions;
using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.SelectItems;

public sealed record SelectItemTotalDate : ISelectItem
{
    public SelectItemTotalDate(string alias, DateTotal expression)
    {
        Alias = alias;
        Expression = expression;
    }

    public string Alias { get; }

    public DateTotal Expression { get; }

    public IType Type => new TypeDate();
}
