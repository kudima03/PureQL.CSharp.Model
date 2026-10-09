using PureQL.CSharp.Model.ProjectionExpressions;
using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.SelectItems;

public sealed record SelectItemProjectionUuidNullable : ISelectItem
{
    public SelectItemProjectionUuidNullable(
        string alias,
        UuidNullableProjection expression
    )
    {
        Alias = alias;
        Expression = expression;
    }

    public string Alias { get; }

    public UuidNullableProjection Expression { get; }

    public IType Type => new TypeUuidNullable();
}
