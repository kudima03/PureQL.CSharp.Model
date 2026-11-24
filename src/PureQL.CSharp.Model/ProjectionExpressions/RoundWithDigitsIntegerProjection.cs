using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.ProjectionExpressions;

/// <summary>PureQL <c>round.withDigits.integer@projection</c>.</summary>
public sealed record RoundWithDigitsIntegerProjection : IOperator
{
    public RoundWithDigitsIntegerProjection(
        IntegerProjection operand,
        IntegerProjection digits,
        RoundingMode mode = RoundingMode.HalfAwayFromZero
    )
    {
        Operand = operand;
        Digits = digits;
        Mode = mode;
    }

    public IntegerProjection Operand { get; }

    public IntegerProjection Digits { get; }

    public RoundingMode Mode { get; }

    public IType Type => new TypeInteger();
}
