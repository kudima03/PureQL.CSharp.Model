using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.GroupExpressions;

/// <summary>PureQL <c>round.decimal@group</c>.</summary>
public sealed record RoundDecimalGroup : IOperator
{
    public RoundDecimalGroup(
        DeclaresDecimalGroup operand,
        IntegerGroup digits,
        RoundingMode mode = RoundingMode.HalfAwayFromZero
    )
    {
        Operand = operand;
        Digits = digits;
        Mode = mode;
    }

    public DeclaresDecimalGroup Operand { get; }

    public IntegerGroup Digits { get; }

    public RoundingMode Mode { get; }

    public IType Type => new TypeDecimal();
}
