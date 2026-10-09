using PureQL.CSharp.Model.GroupExpressions;
using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.SelectItems;

public sealed record SelectItemGroupUuid : ISelectItem
{
    public SelectItemGroupUuid(string alias, UuidGroup expression)
    {
        Alias = alias;
        Expression = expression;
    }

    public string Alias { get; }

    public UuidGroup Expression { get; }

    public IType Type => new TypeUuid();
}
