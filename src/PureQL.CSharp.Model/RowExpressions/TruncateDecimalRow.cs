using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.RowExpressions;

/// <summary>PureQL <c>truncate.decimal@row</c>.</summary>
public sealed record TruncateDecimalRow : IOperator
{
    public TruncateDecimalRow(DeclaresDecimalRow operand, IntegerRow digits)
    {
        Operand = operand;
        Digits = digits;
    }

    public DeclaresDecimalRow Operand { get; }

    public IntegerRow Digits { get; }

    public IType Type => new TypeDecimal();
}
