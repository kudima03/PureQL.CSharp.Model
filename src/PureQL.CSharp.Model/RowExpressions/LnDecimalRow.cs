using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.RowExpressions;

/// <summary>PureQL <c>ln.decimal@row</c>.</summary>
public sealed record LnDecimalRow : IOperator
{
    public LnDecimalRow(DecimalRow operand)
    {
        Operand = operand;
    }

    public DecimalRow Operand { get; }

    public IType Type => new TypeDecimal();
}
