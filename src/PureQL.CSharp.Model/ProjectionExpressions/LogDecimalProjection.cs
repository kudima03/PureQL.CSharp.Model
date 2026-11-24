using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.ProjectionExpressions;

/// <summary>PureQL <c>log.decimal@projection</c>.</summary>
public sealed record LogDecimalProjection : IOperator
{
    public LogDecimalProjection(DecimalProjection operand, DecimalProjection @base)
    {
        Operand = operand;
        Base = @base;
    }

    public DecimalProjection Operand { get; }

    public DecimalProjection Base { get; }

    public IType Type => new TypeDecimal();
}
