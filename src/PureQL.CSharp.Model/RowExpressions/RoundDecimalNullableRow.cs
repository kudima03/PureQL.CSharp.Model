using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.RowExpressions;

public sealed record RoundDecimalNullableRow : IOperator
{
    public RoundDecimalNullableRow(DecimalNullableRow operand, IntegerRow digits)
    {
        Operand = operand;
        Digits = digits;
    }

    public DecimalNullableRow Operand { get; }

    public IntegerRow Digits { get; }

    public IType Type => new TypeDecimalNullable();
}
