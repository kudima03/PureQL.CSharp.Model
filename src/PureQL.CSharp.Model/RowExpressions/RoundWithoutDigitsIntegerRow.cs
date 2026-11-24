using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.RowExpressions;

/// <summary>PureQL <c>round.withoutDigits.integer@row</c>.</summary>
public sealed record RoundWithoutDigitsIntegerRow : IOperator
{
    public RoundWithoutDigitsIntegerRow(
        DeclaresDecimalRow operand,
        RoundingMode mode = RoundingMode.HalfAwayFromZero
    )
    {
        Operand = operand;
        Mode = mode;
    }

    public DeclaresDecimalRow Operand { get; }

    public RoundingMode Mode { get; }

    public IType Type => new TypeInteger();
}
