using PureQL.CSharp.Model.ProjectionExpressions;
using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.SelectItems;

public sealed record SelectItemProjectionBooleanNullable : ISelectItem
{
    public SelectItemProjectionBooleanNullable(
        string alias,
        BooleanNullableProjection expression
    )
    {
        Alias = alias;
        Expression = expression;
    }

    public string Alias { get; }

    public BooleanNullableProjection Expression { get; }

    public IType Type => new TypeBooleanNullable();
}
