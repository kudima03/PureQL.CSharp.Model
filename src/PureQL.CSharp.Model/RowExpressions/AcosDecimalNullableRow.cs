using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.RowExpressions;

/// <summary>PureQL <c>acos.decimal.nullable@row</c>.</summary>
public sealed record AcosDecimalNullableRow : IOperator
{
    public AcosDecimalNullableRow(IntegerNullableOrDecimalNullableRow operand)
    {
        Operand = operand;
    }

    public IntegerNullableOrDecimalNullableRow Operand { get; }

    public IType Type => new TypeDecimalNullable();
}
