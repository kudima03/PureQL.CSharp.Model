using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.RowExpressions;

/// <summary>PureQL <c>round.withDigits.integer@row</c>.</summary>
public sealed record RoundWithDigitsIntegerRow : IOperator
{
    public RoundWithDigitsIntegerRow(
        IntegerRow operand,
        IntegerRow digits,
        RoundingMode mode = RoundingMode.HalfAwayFromZero
    )
    {
        Operand = operand;
        Digits = digits;
        Mode = mode;
    }

    public IntegerRow Operand { get; }

    public IntegerRow Digits { get; }

    public RoundingMode Mode { get; }

    public IType Type => new TypeInteger();
}
