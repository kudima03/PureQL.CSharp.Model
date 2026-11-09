using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.RowExpressions;

/// <summary>PureQL <c>round.decimal.nullable@row</c>.</summary>
public sealed record RoundDecimalNullableRow : IOperator
{
    public RoundDecimalNullableRow(
        IntegerNullableOrDecimalNullableRow operand,
        IntegerRow digits
    )
    {
        Operand = operand;
        Digits = digits;
    }

    public IntegerNullableOrDecimalNullableRow Operand { get; }

    public IntegerRow Digits { get; }

    public IType Type => new TypeDecimalNullable();
}
