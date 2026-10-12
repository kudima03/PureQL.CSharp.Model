using PureQL.CSharp.Model.TotalExpressions;
using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.SelectItems;

public sealed record SelectItemTotalUuid : ISelectItem
{
    public SelectItemTotalUuid(string alias, UuidTotal expression)
    {
        Alias = alias;
        Expression = expression;
    }

    public string Alias { get; }

    public UuidTotal Expression { get; }

    public IType Type => new TypeUuid();
}
