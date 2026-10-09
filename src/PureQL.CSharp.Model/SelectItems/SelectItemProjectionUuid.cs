using PureQL.CSharp.Model.ProjectionExpressions;
using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.SelectItems;

public sealed record SelectItemProjectionUuid : ISelectItem
{
    public SelectItemProjectionUuid(string alias, UuidProjection expression)
    {
        Alias = alias;
        Expression = expression;
    }

    public string Alias { get; }

    public UuidProjection Expression { get; }

    public IType Type => new TypeUuid();
}
