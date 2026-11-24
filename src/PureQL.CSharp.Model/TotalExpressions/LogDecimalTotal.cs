using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.TotalExpressions;

/// <summary>PureQL <c>log.decimal@total</c>.</summary>
public sealed record LogDecimalTotal : IOperator
{
    public LogDecimalTotal(DecimalTotal operand, DecimalTotal @base)
    {
        Operand = operand;
        Base = @base;
    }

    public DecimalTotal Operand { get; }

    public DecimalTotal Base { get; }

    public IType Type => new TypeDecimal();
}
