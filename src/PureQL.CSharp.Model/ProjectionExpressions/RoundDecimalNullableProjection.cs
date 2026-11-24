using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.ProjectionExpressions;

/// <summary>PureQL <c>round.decimal.nullable@projection</c>.</summary>
public sealed record RoundDecimalNullableProjection : IOperator
{
    public RoundDecimalNullableProjection(
        DecimalOrDecimalNullableProjection operand,
        IntegerNullableProjection digits,
        RoundingMode mode = RoundingMode.HalfAwayFromZero
    )
    {
        Operand = operand;
        Digits = digits;
        Mode = mode;
    }

    public DecimalOrDecimalNullableProjection Operand { get; }

    public IntegerNullableProjection Digits { get; }

    public RoundingMode Mode { get; }

    public IType Type => new TypeDecimalNullable();
}
