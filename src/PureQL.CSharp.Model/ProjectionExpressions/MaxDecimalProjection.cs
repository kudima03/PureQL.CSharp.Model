using PureQL.CSharp.Model.RowExpressions;
using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.ProjectionExpressions;

/// <summary>PureQL <c>max.decimal@projection</c>.</summary>
public sealed record MaxDecimalProjection : IOperator
{
    public MaxDecimalProjection(DeclaresDecimalRow selector)
    {
        Selector = selector;
    }

    public DeclaresDecimalRow Selector { get; }

    public IType Type => new TypeDecimal();
}
