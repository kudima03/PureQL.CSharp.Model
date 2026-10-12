using PureQL.CSharp.Model.TotalExpressions;
using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.SelectItems;

public sealed record SelectItemTotalString : ISelectItem
{
    public SelectItemTotalString(string alias, StringTotal expression)
    {
        Alias = alias;
        Expression = expression;
    }

    public string Alias { get; }

    public StringTotal Expression { get; }

    public IType Type => new TypeString();
}
