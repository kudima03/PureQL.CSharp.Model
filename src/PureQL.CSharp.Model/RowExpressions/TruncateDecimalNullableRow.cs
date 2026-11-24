using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.RowExpressions;

/// <summary>PureQL <c>truncate.decimal.nullable@row</c>.</summary>
public sealed record TruncateDecimalNullableRow : IOperator
{
    public TruncateDecimalNullableRow(
        DecimalOrDecimalNullableRow operand,
        IntegerNullableRow digits
    )
    {
        Operand = operand;
        Digits = digits;
    }

    public DecimalOrDecimalNullableRow Operand { get; }

    public IntegerNullableRow Digits { get; }

    public IType Type => new TypeDecimalNullable();
}
