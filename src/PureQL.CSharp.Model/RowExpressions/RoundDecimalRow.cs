using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.RowExpressions;

/// <summary>PureQL <c>round.decimal@row</c>.</summary>
public sealed record RoundDecimalRow : IOperator
{
    public RoundDecimalRow(DecimalRow operand, IntegerRow digits)
    {
        Operand = operand;
        Digits = digits;
    }

    public DecimalRow Operand { get; }

    public IntegerRow Digits { get; }

    public IType Type => new TypeDecimal();
}
