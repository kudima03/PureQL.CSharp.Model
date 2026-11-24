using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.RowExpressions;

/// <summary>PureQL <c>round.decimal.nullable@row</c>.</summary>
public sealed record RoundDecimalNullableRow : IOperator
{
    public RoundDecimalNullableRow(
        DecimalOrDecimalNullableRow operand,
        IntegerNullableRow digits,
        RoundingMode mode = RoundingMode.HalfAwayFromZero
    )
    {
        Operand = operand;
        Digits = digits;
        Mode = mode;
    }

    public DecimalOrDecimalNullableRow Operand { get; }

    public IntegerNullableRow Digits { get; }

    public RoundingMode Mode { get; }

    public IType Type => new TypeDecimalNullable();
}
