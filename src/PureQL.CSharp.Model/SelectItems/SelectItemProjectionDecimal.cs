using PureQL.CSharp.Model.ProjectionExpressions;
using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.SelectItems;

public sealed record SelectItemProjectionDecimal : ISelectItem
{
    public SelectItemProjectionDecimal(string alias, DecimalProjection expression)
    {
        Alias = alias;
        Expression = expression;
    }

    public string Alias { get; }

    public DecimalProjection Expression { get; }

    public IType Type => new TypeDecimal();
}
