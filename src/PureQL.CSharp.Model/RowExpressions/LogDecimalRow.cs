using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.RowExpressions;

/// <summary>PureQL <c>log.decimal@row</c>.</summary>
public sealed record LogDecimalRow : IOperator
{
    public LogDecimalRow(DecimalRow operand, DecimalRow @base)
    {
        Operand = operand;
        Base = @base;
    }

    public DecimalRow Operand { get; }

    public DecimalRow Base { get; }

    public IType Type => new TypeDecimal();
}
