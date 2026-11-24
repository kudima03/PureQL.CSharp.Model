using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.RowExpressions;

/// <summary>PureQL <c>atan.decimal.nullable@row</c>.</summary>
public sealed record AtanDecimalNullableRow : IOperator
{
    public AtanDecimalNullableRow(IntegerNullableOrDecimalNullableRow operand)
    {
        Operand = operand;
    }

    public IntegerNullableOrDecimalNullableRow Operand { get; }

    public IType Type => new TypeDecimalNullable();
}
