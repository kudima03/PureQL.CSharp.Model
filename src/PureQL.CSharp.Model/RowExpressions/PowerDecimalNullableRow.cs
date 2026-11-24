using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.RowExpressions;

/// <summary>PureQL <c>power.decimal.nullable@row</c>.</summary>
public sealed record PowerDecimalNullableRow : IOperator
{
    public PowerDecimalNullableRow(
        DecimalNullableRow operand,
        DecimalNullableRow exponent
    )
    {
        Operand = operand;
        Exponent = exponent;
    }

    public DecimalNullableRow Operand { get; }

    public DecimalNullableRow Exponent { get; }

    public IType Type => new TypeDecimalNullable();
}
