using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.ProjectionExpressions;

/// <summary>PureQL <c>power.decimal@projection</c>.</summary>
public sealed record PowerDecimalProjection : IOperator
{
    public PowerDecimalProjection(DecimalProjection operand, DecimalProjection exponent)
    {
        Operand = operand;
        Exponent = exponent;
    }

    public DecimalProjection Operand { get; }

    public DecimalProjection Exponent { get; }

    public IType Type => new TypeDecimal();
}
