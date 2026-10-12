using PureQL.CSharp.Model.TotalExpressions;
using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.SelectItems;

public sealed record SelectItemTotalBoolean : ISelectItem
{
    public SelectItemTotalBoolean(string alias, BooleanTotal expression)
    {
        Alias = alias;
        Expression = expression;
    }

    public string Alias { get; }

    public BooleanTotal Expression { get; }

    public IType Type => new TypeBoolean();
}
