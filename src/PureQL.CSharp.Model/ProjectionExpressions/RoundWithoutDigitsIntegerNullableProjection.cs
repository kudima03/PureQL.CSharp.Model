using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.ProjectionExpressions;

/// <summary>PureQL <c>round.withoutDigits.integer.nullable@projection</c>.</summary>
public sealed record RoundWithoutDigitsIntegerNullableProjection : IOperator
{
    public RoundWithoutDigitsIntegerNullableProjection(
        DeclaresDecimalNullableProjection operand,
        RoundingMode mode = RoundingMode.HalfAwayFromZero
    )
    {
        Operand = operand;
        Mode = mode;
    }

    public DeclaresDecimalNullableProjection Operand { get; }

    public RoundingMode Mode { get; }

    public IType Type => new TypeIntegerNullable();
}
