using PureQL.CSharp.Model.ProjectionExpressions;
using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.SelectItems;

public sealed record SelectItemProjectionDecimal : ISelectItem
{
    public SelectItemProjectionDecimal(string alias, ExactDecimalProjection expression)
    {
        Alias = alias;
        Expression = expression;
    }

    public string Alias { get; }

    public ExactDecimalProjection Expression { get; }

    public IType Type => new TypeDecimal();
}
