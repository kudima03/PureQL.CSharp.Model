using PureQL.CSharp.Model.ProjectionExpressions;
using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.SelectItems;

public sealed record SelectItemProjectionUuidNullable : ISelectItem
{
    public SelectItemProjectionUuidNullable(
        string alias,
        ExactUuidNullableProjection expression
    )
    {
        Alias = alias;
        Expression = expression;
    }

    public string Alias { get; }

    public ExactUuidNullableProjection Expression { get; }

    public IType Type => new TypeUuidNullable();
}
