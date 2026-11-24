using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.TotalExpressions;

/// <summary>PureQL <c>truncate.decimal.nullable@total</c>.</summary>
public sealed record TruncateDecimalNullableTotal : IOperator
{
    public TruncateDecimalNullableTotal(
        DecimalOrDecimalNullableTotal operand,
        IntegerNullableTotal digits
    )
    {
        Operand = operand;
        Digits = digits;
    }

    public DecimalOrDecimalNullableTotal Operand { get; }

    public IntegerNullableTotal Digits { get; }

    public IType Type => new TypeDecimalNullable();
}
