using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.TotalExpressions;

/// <summary>PureQL <c>sin.decimal@total</c>.</summary>
public sealed record SinDecimalTotal : IOperator
{
    public SinDecimalTotal(DecimalTotal operand)
    {
        Operand = operand;
    }

    public DecimalTotal Operand { get; }

    public IType Type => new TypeDecimal();
}
