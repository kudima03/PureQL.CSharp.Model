using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.GroupExpressions;

/// <summary>PureQL <c>round.withDigits.integer.nullable@group</c>.</summary>
public sealed record RoundWithDigitsIntegerNullableGroup : IOperator
{
    public RoundWithDigitsIntegerNullableGroup(
        IntegerNullableGroup operand,
        IntegerNullableGroup digits,
        RoundingMode mode = RoundingMode.HalfAwayFromZero
    )
    {
        Operand = operand;
        Digits = digits;
        Mode = mode;
    }

    public IntegerNullableGroup Operand { get; }

    public IntegerNullableGroup Digits { get; }

    public RoundingMode Mode { get; }

    public IType Type => new TypeIntegerNullable();
}
