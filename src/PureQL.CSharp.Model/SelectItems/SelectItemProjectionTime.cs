using PureQL.CSharp.Model.ProjectionExpressions;
using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.SelectItems;

public sealed record SelectItemProjectionTime : ISelectItem
{
    public SelectItemProjectionTime(string alias, TimeProjection expression)
    {
        Alias = alias;
        Expression = expression;
    }

    public string Alias { get; }

    public TimeProjection Expression { get; }

    public IType Type => new TypeTime();
}
