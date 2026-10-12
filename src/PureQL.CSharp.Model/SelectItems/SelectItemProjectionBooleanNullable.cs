using PureQL.CSharp.Model.ProjectionExpressions;
using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.SelectItems;

public sealed record SelectItemProjectionBooleanNullable : ISelectItem
{
    public SelectItemProjectionBooleanNullable(
        string alias,
        ExactBooleanNullableProjection expression
    )
    {
        Alias = alias;
        Expression = expression;
    }

    public string Alias { get; }

    public ExactBooleanNullableProjection Expression { get; }

    public IType Type => new TypeBooleanNullable();
}
