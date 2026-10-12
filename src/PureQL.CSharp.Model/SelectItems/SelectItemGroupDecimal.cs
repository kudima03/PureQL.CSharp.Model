using PureQL.CSharp.Model.GroupExpressions;
using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.SelectItems;

public sealed record SelectItemGroupDecimal : ISelectItem
{
    public SelectItemGroupDecimal(string alias, ExactDecimalGroup expression)
    {
        Alias = alias;
        Expression = expression;
    }

    public string Alias { get; }

    public ExactDecimalGroup Expression { get; }

    public IType Type => new TypeDecimal();
}
