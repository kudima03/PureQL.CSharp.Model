using PureQL.CSharp.Model.ProjectionExpressions;
using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.SelectItems;

public sealed record SelectItemProjectionStringNullable : ISelectItem
{
    public SelectItemProjectionStringNullable(
        string alias,
        StringNullableProjection expression
    )
    {
        Alias = alias;
        Expression = expression;
    }

    public string Alias { get; }

    public StringNullableProjection Expression { get; }

    public IType Type => new TypeStringNullable();
}
