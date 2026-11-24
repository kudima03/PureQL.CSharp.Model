using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.TotalExpressions;

/// <summary>PureQL <c>round.withDigits.integer.nullable@total</c>.</summary>
public sealed record RoundWithDigitsIntegerNullableTotal : IOperator
{
    public RoundWithDigitsIntegerNullableTotal(
        IntegerNullableTotal operand,
        IntegerNullableTotal digits,
        RoundingMode mode = RoundingMode.HalfAwayFromZero
    )
    {
        Operand = operand;
        Digits = digits;
        Mode = mode;
    }

    public IntegerNullableTotal Operand { get; }

    public IntegerNullableTotal Digits { get; }

    public RoundingMode Mode { get; }

    public IType Type => new TypeIntegerNullable();
}
