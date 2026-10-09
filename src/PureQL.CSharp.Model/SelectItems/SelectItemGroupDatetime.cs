using PureQL.CSharp.Model.GroupExpressions;
using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.SelectItems;

public sealed record SelectItemGroupDatetime : ISelectItem
{
    public SelectItemGroupDatetime(string alias, DatetimeGroup expression)
    {
        Alias = alias;
        Expression = expression;
    }

    public string Alias { get; }

    public DatetimeGroup Expression { get; }

    public IType Type => new TypeDatetime();
}
