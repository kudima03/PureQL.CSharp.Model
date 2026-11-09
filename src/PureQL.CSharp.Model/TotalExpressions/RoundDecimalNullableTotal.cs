using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.TotalExpressions;

/// <summary>PureQL <c>round.decimal.nullable@total</c>.</summary>
public sealed record RoundDecimalNullableTotal : IOperator
{
    public RoundDecimalNullableTotal(
        IntegerNullableOrDecimalNullableTotal operand,
        IntegerTotal digits
    )
    {
        Operand = operand;
        Digits = digits;
    }

    public IntegerNullableOrDecimalNullableTotal Operand { get; }

    public IntegerTotal Digits { get; }

    public IType Type => new TypeDecimalNullable();
}
