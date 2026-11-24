using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.ProjectionExpressions;

/// <summary>PureQL <c>cos.decimal@projection</c>.</summary>
public sealed record CosDecimalProjection : IOperator
{
    public CosDecimalProjection(DecimalProjection operand)
    {
        Operand = operand;
    }

    public DecimalProjection Operand { get; }

    public IType Type => new TypeDecimal();
}
