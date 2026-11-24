using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.TotalExpressions;

/// <summary>PureQL <c>cos.decimal@total</c>.</summary>
public sealed record CosDecimalTotal : IOperator
{
    public CosDecimalTotal(DecimalTotal operand)
    {
        Operand = operand;
    }

    public DecimalTotal Operand { get; }

    public IType Type => new TypeDecimal();
}
