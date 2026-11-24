using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.ProjectionExpressions;

/// <summary>PureQL <c>round.withDigits.integer.nullable@projection</c>.</summary>
public sealed record RoundWithDigitsIntegerNullableProjection : IOperator
{
    public RoundWithDigitsIntegerNullableProjection(
        IntegerNullableProjection operand,
        IntegerNullableProjection digits,
        RoundingMode mode = RoundingMode.HalfAwayFromZero
    )
    {
        Operand = operand;
        Digits = digits;
        Mode = mode;
    }

    public IntegerNullableProjection Operand { get; }

    public IntegerNullableProjection Digits { get; }

    public RoundingMode Mode { get; }

    public IType Type => new TypeIntegerNullable();
}
