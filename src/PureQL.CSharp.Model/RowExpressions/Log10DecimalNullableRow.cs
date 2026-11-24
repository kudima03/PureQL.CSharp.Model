using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.RowExpressions;

/// <summary>PureQL <c>log10.decimal.nullable@row</c>.</summary>
public sealed record Log10DecimalNullableRow : IOperator
{
    public Log10DecimalNullableRow(IntegerNullableOrDecimalNullableRow operand)
    {
        Operand = operand;
    }

    public IntegerNullableOrDecimalNullableRow Operand { get; }

    public IType Type => new TypeDecimalNullable();
}
