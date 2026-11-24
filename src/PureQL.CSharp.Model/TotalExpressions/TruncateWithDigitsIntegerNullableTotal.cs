using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.TotalExpressions;

/// <summary>PureQL <c>truncate.withDigits.integer.nullable@total</c>.</summary>
public sealed record TruncateWithDigitsIntegerNullableTotal : IOperator
{
    public TruncateWithDigitsIntegerNullableTotal(
        IntegerNullableTotal operand,
        IntegerNullableTotal digits
    )
    {
        Operand = operand;
        Digits = digits;
    }

    public IntegerNullableTotal Operand { get; }

    public IntegerNullableTotal Digits { get; }

    public IType Type => new TypeIntegerNullable();
}
