using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.TotalExpressions;

/// <summary>PureQL <c>abs.decimal@total</c>.</summary>
public sealed record AbsDecimalTotal : IOperator
{
    public AbsDecimalTotal(DeclaresDecimalTotal operand)
    {
        Operand = operand;
    }

    public DeclaresDecimalTotal Operand { get; }

    public IType Type => new TypeDecimal();
}
