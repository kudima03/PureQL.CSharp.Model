using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.RowExpressions;

/// <summary>PureQL <c>cos.decimal.nullable@row</c>.</summary>
public sealed record CosDecimalNullableRow : IOperator
{
    public CosDecimalNullableRow(IntegerNullableOrDecimalNullableRow operand)
    {
        Operand = operand;
    }

    public IntegerNullableOrDecimalNullableRow Operand { get; }

    public IType Type => new TypeDecimalNullable();
}
