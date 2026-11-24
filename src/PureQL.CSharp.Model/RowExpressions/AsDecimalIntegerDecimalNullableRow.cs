using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.RowExpressions;

/// <summary>PureQL <c>asDecimal.integer.decimal.nullable@row</c>.</summary>
public sealed record AsDecimalIntegerDecimalNullableRow : IOperator
{
    public AsDecimalIntegerDecimalNullableRow(DeclaresIntegerNullableRow operand)
    {
        Operand = operand;
    }

    public DeclaresIntegerNullableRow Operand { get; }

    public IType Type => new TypeDecimalNullable();
}
