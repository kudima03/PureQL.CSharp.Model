using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.TotalExpressions;

/// <summary>PureQL <c>truncate.withDigits.integer@total</c>.</summary>
public sealed record TruncateWithDigitsIntegerTotal : IOperator
{
    public TruncateWithDigitsIntegerTotal(IntegerTotal operand, IntegerTotal digits)
    {
        Operand = operand;
        Digits = digits;
    }

    public IntegerTotal Operand { get; }

    public IntegerTotal Digits { get; }

    public IType Type => new TypeInteger();
}
