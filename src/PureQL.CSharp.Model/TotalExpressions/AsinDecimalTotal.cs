using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.TotalExpressions;

/// <summary>PureQL <c>asin.decimal@total</c>.</summary>
public sealed record AsinDecimalTotal : IOperator
{
    public AsinDecimalTotal(DecimalTotal operand)
    {
        Operand = operand;
    }

    public DecimalTotal Operand { get; }

    public IType Type => new TypeDecimal();
}
