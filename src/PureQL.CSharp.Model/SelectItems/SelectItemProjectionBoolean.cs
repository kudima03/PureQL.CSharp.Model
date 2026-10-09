using PureQL.CSharp.Model.ProjectionExpressions;
using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.SelectItems;

public sealed record SelectItemProjectionBoolean : ISelectItem
{
    public SelectItemProjectionBoolean(string alias, BooleanProjection expression)
    {
        Alias = alias;
        Expression = expression;
    }

    public string Alias { get; }

    public BooleanProjection Expression { get; }

    public IType Type => new TypeBoolean();
}
