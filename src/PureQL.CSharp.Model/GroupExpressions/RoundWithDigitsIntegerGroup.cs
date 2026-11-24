using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.GroupExpressions;

/// <summary>PureQL <c>round.withDigits.integer@group</c>.</summary>
public sealed record RoundWithDigitsIntegerGroup : IOperator
{
    public RoundWithDigitsIntegerGroup(
        IntegerGroup operand,
        IntegerGroup digits,
        RoundingMode mode = RoundingMode.HalfAwayFromZero
    )
    {
        Operand = operand;
        Digits = digits;
        Mode = mode;
    }

    public IntegerGroup Operand { get; }

    public IntegerGroup Digits { get; }

    public RoundingMode Mode { get; }

    public IType Type => new TypeInteger();
}
