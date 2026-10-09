using PureQL.CSharp.Model.ProjectionExpressions;
using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.SelectItems;

public sealed record SelectItemProjectionDecimalNullable : ISelectItem
{
    public SelectItemProjectionDecimalNullable(
        string alias,
        DecimalNullableProjection expression
    )
    {
        Alias = alias;
        Expression = expression;
    }

    public string Alias { get; }

    public DecimalNullableProjection Expression { get; }

    public IType Type => new TypeDecimalNullable();
}
