using PureQL.CSharp.Model.ProjectionExpressions;
using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.SelectItems;

public sealed record SelectItemProjectionIntegerNullable : ISelectItem
{
    public SelectItemProjectionIntegerNullable(
        string alias,
        ExactIntegerNullableProjection expression
    )
    {
        Alias = alias;
        Expression = expression;
    }

    public string Alias { get; }

    public ExactIntegerNullableProjection Expression { get; }

    public IType Type => new TypeIntegerNullable();
}
