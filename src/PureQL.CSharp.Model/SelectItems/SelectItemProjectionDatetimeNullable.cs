using PureQL.CSharp.Model.ProjectionExpressions;
using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.SelectItems;

public sealed record SelectItemProjectionDatetimeNullable : ISelectItem
{
    public SelectItemProjectionDatetimeNullable(
        string alias,
        DatetimeNullableProjection expression
    )
    {
        Alias = alias;
        Expression = expression;
    }

    public string Alias { get; }

    public DatetimeNullableProjection Expression { get; }

    public IType Type => new TypeDatetimeNullable();
}
