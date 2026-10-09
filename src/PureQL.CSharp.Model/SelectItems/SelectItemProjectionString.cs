using PureQL.CSharp.Model.ProjectionExpressions;
using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.SelectItems;

public sealed record SelectItemProjectionString : ISelectItem
{
    public SelectItemProjectionString(string alias, StringProjection expression)
    {
        Alias = alias;
        Expression = expression;
    }

    public string Alias { get; }

    public StringProjection Expression { get; }

    public IType Type => new TypeString();
}
