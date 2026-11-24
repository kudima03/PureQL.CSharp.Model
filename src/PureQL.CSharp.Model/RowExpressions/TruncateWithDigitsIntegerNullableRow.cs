using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.RowExpressions;

/// <summary>PureQL <c>truncate.withDigits.integer.nullable@row</c>.</summary>
public sealed record TruncateWithDigitsIntegerNullableRow : IOperator
{
    public TruncateWithDigitsIntegerNullableRow(
        IntegerNullableRow operand,
        IntegerNullableRow digits
    )
    {
        Operand = operand;
        Digits = digits;
    }

    public IntegerNullableRow Operand { get; }

    public IntegerNullableRow Digits { get; }

    public IType Type => new TypeIntegerNullable();
}
