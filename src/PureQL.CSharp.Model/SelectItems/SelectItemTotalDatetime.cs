using PureQL.CSharp.Model.TotalExpressions;
using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.SelectItems;

public sealed record SelectItemTotalDatetime : ISelectItem
{
    public SelectItemTotalDatetime(string alias, DatetimeTotal expression)
    {
        Alias = alias;
        Expression = expression;
    }

    public string Alias { get; }

    public DatetimeTotal Expression { get; }

    public IType Type => new TypeDatetime();
}
