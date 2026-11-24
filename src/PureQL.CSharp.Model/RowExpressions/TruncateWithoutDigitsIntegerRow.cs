using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.RowExpressions;

/// <summary>PureQL <c>truncate.withoutDigits.integer@row</c>.</summary>
public sealed record TruncateWithoutDigitsIntegerRow : IOperator
{
    public TruncateWithoutDigitsIntegerRow(DeclaresDecimalRow operand)
    {
        Operand = operand;
    }

    public DeclaresDecimalRow Operand { get; }

    public IType Type => new TypeInteger();
}
