using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.TotalExpressions;

/// <summary>PureQL <c>power.decimal@total</c>.</summary>
public sealed record PowerDecimalTotal : IOperator
{
    public PowerDecimalTotal(DecimalTotal operand, DecimalTotal exponent)
    {
        Operand = operand;
        Exponent = exponent;
    }

    public DecimalTotal Operand { get; }

    public DecimalTotal Exponent { get; }

    public IType Type => new TypeDecimal();
}
