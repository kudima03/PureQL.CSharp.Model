using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.TotalExpressions;

/// <summary>PureQL <c>round.integer@total</c>.</summary>
public sealed record RoundIntegerTotal : IOperator
{
    public RoundIntegerTotal(DecimalTotal operand)
    {
        Operand = operand;
    }

    public DecimalTotal Operand { get; }

    public IType Type => new TypeInteger();
}
