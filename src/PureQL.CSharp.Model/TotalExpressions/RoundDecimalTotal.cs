using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.TotalExpressions;

public sealed record RoundDecimalTotal : IOperator
{
    public RoundDecimalTotal(DecimalTotal operand, IntegerTotal digits)
    {
        Operand = operand;
        Digits = digits;
    }

    public DecimalTotal Operand { get; }

    public IntegerTotal Digits { get; }

    public IType Type => new TypeDecimal();
}
