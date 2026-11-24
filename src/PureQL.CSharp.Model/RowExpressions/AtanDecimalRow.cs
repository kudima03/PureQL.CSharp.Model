using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.RowExpressions;

/// <summary>PureQL <c>atan.decimal@row</c>.</summary>
public sealed record AtanDecimalRow : IOperator
{
    public AtanDecimalRow(DecimalRow operand)
    {
        Operand = operand;
    }

    public DecimalRow Operand { get; }

    public IType Type => new TypeDecimal();
}
