using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.TotalExpressions;

/// <summary>PureQL <c>round.withDigits.integer@total</c>.</summary>
public sealed record RoundWithDigitsIntegerTotal : IOperator
{
    public RoundWithDigitsIntegerTotal(
        IntegerTotal operand,
        IntegerTotal digits,
        RoundingMode mode = RoundingMode.HalfAwayFromZero
    )
    {
        Operand = operand;
        Digits = digits;
        Mode = mode;
    }

    public IntegerTotal Operand { get; }

    public IntegerTotal Digits { get; }

    public RoundingMode Mode { get; }

    public IType Type => new TypeInteger();
}
