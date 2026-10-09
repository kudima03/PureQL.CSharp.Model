using PureQL.CSharp.Model.ProjectionExpressions;
using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.SelectItems;

public sealed record SelectItemProjectionDate : ISelectItem
{
    public SelectItemProjectionDate(string alias, DateProjection expression)
    {
        Alias = alias;
        Expression = expression;
    }

    public string Alias { get; }

    public DateProjection Expression { get; }

    public IType Type => new TypeDate();
}
