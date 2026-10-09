using PureQL.CSharp.Model.ProjectionExpressions;
using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.SelectItems;

public sealed record SelectItemProjectionDatetime : ISelectItem
{
    public SelectItemProjectionDatetime(string alias, DatetimeProjection expression)
    {
        Alias = alias;
        Expression = expression;
    }

    public string Alias { get; }

    public DatetimeProjection Expression { get; }

    public IType Type => new TypeDatetime();
}
