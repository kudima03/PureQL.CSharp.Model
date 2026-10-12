using PureQL.CSharp.Model.ProjectionExpressions;
using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.SelectItems;

public sealed record SelectItemProjectionStringNullable : ISelectItem
{
    public SelectItemProjectionStringNullable(
        string alias,
        ExactStringNullableProjection expression
    )
    {
        Alias = alias;
        Expression = expression;
    }

    public string Alias { get; }

    public ExactStringNullableProjection Expression { get; }

    public IType Type => new TypeStringNullable();
}
