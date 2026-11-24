using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.TotalExpressions;

/// <summary>PureQL <c>round.decimal@total</c>.</summary>
public sealed record RoundDecimalTotal : IOperator
{
    public RoundDecimalTotal(
        DeclaresDecimalTotal operand,
        IntegerTotal digits,
        RoundingMode mode = RoundingMode.HalfAwayFromZero
    )
    {
        Operand = operand;
        Digits = digits;
        Mode = mode;
    }

    public DeclaresDecimalTotal Operand { get; }

    public IntegerTotal Digits { get; }

    public RoundingMode Mode { get; }

    public IType Type => new TypeDecimal();
}
