using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.TotalExpressions;

/// <summary>PureQL <c>round.decimal.nullable@total</c>.</summary>
public sealed record RoundDecimalNullableTotal : IOperator
{
    public RoundDecimalNullableTotal(
        DecimalOrDecimalNullableTotal operand,
        IntegerNullableTotal digits,
        RoundingMode mode = RoundingMode.HalfAwayFromZero
    )
    {
        Operand = operand;
        Digits = digits;
        Mode = mode;
    }

    public DecimalOrDecimalNullableTotal Operand { get; }

    public IntegerNullableTotal Digits { get; }

    public RoundingMode Mode { get; }

    public IType Type => new TypeDecimalNullable();
}
