using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.RowExpressions;

/// <summary>PureQL <c>tan.decimal@row</c>.</summary>
public sealed record TanDecimalRow : IOperator
{
    public TanDecimalRow(DecimalRow operand)
    {
        Operand = operand;
    }

    public DecimalRow Operand { get; }

    public IType Type => new TypeDecimal();
}
