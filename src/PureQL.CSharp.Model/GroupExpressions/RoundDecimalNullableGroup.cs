using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.GroupExpressions;

/// <summary>PureQL <c>round.decimal.nullable@group</c>.</summary>
public sealed record RoundDecimalNullableGroup : IOperator
{
    public RoundDecimalNullableGroup(
        DecimalOrDecimalNullableGroup operand,
        IntegerNullableGroup digits,
        RoundingMode mode = RoundingMode.HalfAwayFromZero
    )
    {
        Operand = operand;
        Digits = digits;
        Mode = mode;
    }

    public DecimalOrDecimalNullableGroup Operand { get; }

    public IntegerNullableGroup Digits { get; }

    public RoundingMode Mode { get; }

    public IType Type => new TypeDecimalNullable();
}
