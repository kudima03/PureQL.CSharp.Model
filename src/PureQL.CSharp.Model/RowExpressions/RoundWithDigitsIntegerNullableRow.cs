using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.RowExpressions;

/// <summary>PureQL <c>round.withDigits.integer.nullable@row</c>.</summary>
public sealed record RoundWithDigitsIntegerNullableRow : IOperator
{
    public RoundWithDigitsIntegerNullableRow(
        IntegerNullableRow operand,
        IntegerNullableRow digits,
        RoundingMode mode = RoundingMode.HalfAwayFromZero
    )
    {
        Operand = operand;
        Digits = digits;
        Mode = mode;
    }

    public IntegerNullableRow Operand { get; }

    public IntegerNullableRow Digits { get; }

    public RoundingMode Mode { get; }

    public IType Type => new TypeIntegerNullable();
}
