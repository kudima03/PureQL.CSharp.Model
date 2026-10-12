using PureQL.CSharp.Model.TotalExpressions;
using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.SelectItems;

public sealed record SelectItemTotalUuidNullable : ISelectItem
{
    public SelectItemTotalUuidNullable(string alias, ExactUuidNullableTotal expression)
    {
        Alias = alias;
        Expression = expression;
    }

    public string Alias { get; }

    public ExactUuidNullableTotal Expression { get; }

    public IType Type => new TypeUuidNullable();
}
