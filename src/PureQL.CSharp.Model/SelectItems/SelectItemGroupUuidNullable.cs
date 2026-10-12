using PureQL.CSharp.Model.GroupExpressions;
using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.SelectItems;

public sealed record SelectItemGroupUuidNullable : ISelectItem
{
    public SelectItemGroupUuidNullable(string alias, ExactUuidNullableGroup expression)
    {
        Alias = alias;
        Expression = expression;
    }

    public string Alias { get; }

    public ExactUuidNullableGroup Expression { get; }

    public IType Type => new TypeUuidNullable();
}
