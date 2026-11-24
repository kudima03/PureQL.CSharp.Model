using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.TotalExpressions;

/// <summary>PureQL <c>ceiling.integer@total</c>.</summary>
public sealed record CeilingIntegerTotal : IOperator
{
    public CeilingIntegerTotal(DeclaresDecimalTotal operand)
    {
        Operand = operand;
    }

    public DeclaresDecimalTotal Operand { get; }

    public IType Type => new TypeInteger();
}
