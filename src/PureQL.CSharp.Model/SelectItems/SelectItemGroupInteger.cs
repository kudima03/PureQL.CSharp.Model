using PureQL.CSharp.Model.GroupExpressions;
using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.SelectItems;

public sealed record SelectItemGroupInteger : ISelectItem
{
    public SelectItemGroupInteger(string alias, IntegerGroup expression)
    {
        Alias = alias;
        Expression = expression;
    }

    public string Alias { get; }

    public IntegerGroup Expression { get; }

    public IType Type => new TypeInteger();
}
