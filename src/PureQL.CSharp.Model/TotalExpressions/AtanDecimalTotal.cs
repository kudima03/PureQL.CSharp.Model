using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.TotalExpressions;

/// <summary>PureQL <c>atan.decimal@total</c>.</summary>
public sealed record AtanDecimalTotal : IOperator
{
    public AtanDecimalTotal(DecimalTotal operand)
    {
        Operand = operand;
    }

    public DecimalTotal Operand { get; }

    public IType Type => new TypeDecimal();
}
