using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.RowExpressions;

/// <summary>PureQL <c>exp.decimal@row</c>.</summary>
public sealed record ExpDecimalRow : IOperator
{
    public ExpDecimalRow(DecimalRow operand)
    {
        Operand = operand;
    }

    public DecimalRow Operand { get; }

    public IType Type => new TypeDecimal();
}
