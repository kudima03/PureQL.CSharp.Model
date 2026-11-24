using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.RowExpressions;

/// <summary>PureQL <c>asDecimal.integer.decimal@row</c>.</summary>
public sealed record AsDecimalIntegerDecimalRow : IOperator
{
    public AsDecimalIntegerDecimalRow(IntegerRow operand)
    {
        Operand = operand;
    }

    public IntegerRow Operand { get; }

    public IType Type => new TypeDecimal();
}
