using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.RowExpressions;

/// <summary>PureQL <c>cos.decimal@row</c>.</summary>
public sealed record CosDecimalRow : IOperator
{
    public CosDecimalRow(DecimalRow operand)
    {
        Operand = operand;
    }

    public DecimalRow Operand { get; }

    public IType Type => new TypeDecimal();
}
