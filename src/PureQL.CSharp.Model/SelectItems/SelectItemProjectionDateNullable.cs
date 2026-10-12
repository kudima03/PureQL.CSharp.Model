using PureQL.CSharp.Model.ProjectionExpressions;
using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.SelectItems;

public sealed record SelectItemProjectionDateNullable : ISelectItem
{
    public SelectItemProjectionDateNullable(
        string alias,
        ExactDateNullableProjection expression
    )
    {
        Alias = alias;
        Expression = expression;
    }

    public string Alias { get; }

    public ExactDateNullableProjection Expression { get; }

    public IType Type => new TypeDateNullable();
}
