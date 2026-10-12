using PureQL.CSharp.Model.TotalExpressions;
using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.SelectItems;

public sealed record SelectItemTotalDecimal : ISelectItem
{
    public SelectItemTotalDecimal(string alias, ExactDecimalTotal expression)
    {
        Alias = alias;
        Expression = expression;
    }

    public string Alias { get; }

    public ExactDecimalTotal Expression { get; }

    public IType Type => new TypeDecimal();
}
