using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.TotalExpressions;

/// <summary>PureQL <c>ln.decimal@total</c>.</summary>
public sealed record LnDecimalTotal : IOperator
{
    public LnDecimalTotal(DecimalTotal operand)
    {
        Operand = operand;
    }

    public DecimalTotal Operand { get; }

    public IType Type => new TypeDecimal();
}
