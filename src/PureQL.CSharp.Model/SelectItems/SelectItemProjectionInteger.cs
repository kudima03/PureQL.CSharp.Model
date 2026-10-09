using PureQL.CSharp.Model.ProjectionExpressions;
using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.SelectItems;

public sealed record SelectItemProjectionInteger : ISelectItem
{
    public SelectItemProjectionInteger(string alias, IntegerProjection expression)
    {
        Alias = alias;
        Expression = expression;
    }

    public string Alias { get; }

    public IntegerProjection Expression { get; }

    public IType Type => new TypeInteger();
}
