using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.TotalExpressions;

/// <summary>PureQL <c>round.withoutDigits.integer@total</c>.</summary>
public sealed record RoundWithoutDigitsIntegerTotal : IOperator
{
    public RoundWithoutDigitsIntegerTotal(
        DeclaresDecimalTotal operand,
        RoundingMode mode = RoundingMode.HalfAwayFromZero
    )
    {
        Operand = operand;
        Mode = mode;
    }

    public DeclaresDecimalTotal Operand { get; }

    public RoundingMode Mode { get; }

    public IType Type => new TypeInteger();
}
