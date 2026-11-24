using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.RowExpressions;

/// <summary>PureQL <c>power.decimal@row</c>.</summary>
public sealed record PowerDecimalRow : IOperator
{
    public PowerDecimalRow(DecimalRow operand, DecimalRow exponent)
    {
        Operand = operand;
        Exponent = exponent;
    }

    public DecimalRow Operand { get; }

    public DecimalRow Exponent { get; }

    public IType Type => new TypeDecimal();
}
