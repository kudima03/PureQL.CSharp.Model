using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.RowExpressions;

/// <summary>PureQL <c>truncate.withDigits.integer@row</c>.</summary>
public sealed record TruncateWithDigitsIntegerRow : IOperator
{
    public TruncateWithDigitsIntegerRow(IntegerRow operand, IntegerRow digits)
    {
        Operand = operand;
        Digits = digits;
    }

    public IntegerRow Operand { get; }

    public IntegerRow Digits { get; }

    public IType Type => new TypeInteger();
}
