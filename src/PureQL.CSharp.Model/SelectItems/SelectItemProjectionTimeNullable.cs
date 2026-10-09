using PureQL.CSharp.Model.ProjectionExpressions;
using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.SelectItems;

public sealed record SelectItemProjectionTimeNullable : ISelectItem
{
    public SelectItemProjectionTimeNullable(
        string alias,
        TimeNullableProjection expression
    )
    {
        Alias = alias;
        Expression = expression;
    }

    public string Alias { get; }

    public TimeNullableProjection Expression { get; }

    public IType Type => new TypeTimeNullable();
}
