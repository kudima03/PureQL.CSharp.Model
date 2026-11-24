using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.RowExpressions;

/// <summary>PureQL <c>round.decimal@row</c>.</summary>
public sealed record RoundDecimalRow : IOperator
{
    public RoundDecimalRow(
        DeclaresDecimalRow operand,
        IntegerRow digits,
        RoundingMode mode = RoundingMode.HalfAwayFromZero
    )
    {
        Operand = operand;
        Digits = digits;
        Mode = mode;
    }

    public DeclaresDecimalRow Operand { get; }

    public IntegerRow Digits { get; }

    public RoundingMode Mode { get; }

    public IType Type => new TypeDecimal();
}
