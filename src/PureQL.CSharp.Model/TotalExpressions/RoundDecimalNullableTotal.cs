using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.TotalExpressions;

public sealed record RoundDecimalNullableTotal : IOperator
{
    public RoundDecimalNullableTotal(DecimalNullableTotal operand, IntegerTotal digits)
    {
        Operand = operand;
        Digits = digits;
    }

    public DecimalNullableTotal Operand { get; }

    public IntegerTotal Digits { get; }

    public IType Type => new TypeDecimalNullable();
}
