using PureQL.CSharp.Model.ProjectionExpressions;
using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.SelectItems;

public sealed record SelectItemProjectionDecimalNullable : ISelectItem
{
    public SelectItemProjectionDecimalNullable(
        string alias,
        ExactDecimalNullableProjection expression
    )
    {
        Alias = alias;
        Expression = expression;
    }

    public string Alias { get; }

    public ExactDecimalNullableProjection Expression { get; }

    public IType Type => new TypeDecimalNullable();
}
