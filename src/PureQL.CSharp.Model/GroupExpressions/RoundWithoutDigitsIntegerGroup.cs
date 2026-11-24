using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.GroupExpressions;

/// <summary>PureQL <c>round.withoutDigits.integer@group</c>.</summary>
public sealed record RoundWithoutDigitsIntegerGroup : IOperator
{
    public RoundWithoutDigitsIntegerGroup(
        DeclaresDecimalGroup operand,
        RoundingMode mode = RoundingMode.HalfAwayFromZero
    )
    {
        Operand = operand;
        Mode = mode;
    }

    public DeclaresDecimalGroup Operand { get; }

    public RoundingMode Mode { get; }

    public IType Type => new TypeInteger();
}
