using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.RowExpressions;

/// <summary>PureQL <c>tan.decimal.nullable@row</c>.</summary>
public sealed record TanDecimalNullableRow : IOperator
{
    public TanDecimalNullableRow(IntegerNullableOrDecimalNullableRow operand)
    {
        Operand = operand;
    }

    public IntegerNullableOrDecimalNullableRow Operand { get; }

    public IType Type => new TypeDecimalNullable();
}
