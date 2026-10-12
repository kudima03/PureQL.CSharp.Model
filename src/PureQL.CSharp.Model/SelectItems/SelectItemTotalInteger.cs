using PureQL.CSharp.Model.TotalExpressions;
using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.SelectItems;

public sealed record SelectItemTotalInteger : ISelectItem
{
    public SelectItemTotalInteger(string alias, IntegerTotal expression)
    {
        Alias = alias;
        Expression = expression;
    }

    public string Alias { get; }

    public IntegerTotal Expression { get; }

    public IType Type => new TypeInteger();
}
