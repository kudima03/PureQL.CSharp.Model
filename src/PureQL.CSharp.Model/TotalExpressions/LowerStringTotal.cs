using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.TotalExpressions;

/// <summary>PureQL <c>lower.string@total</c>.</summary>
public sealed record LowerStringTotal : IOperator
{
    public LowerStringTotal(StringTotal operand)
    {
        Operand = operand;
    }

    public StringTotal Operand { get; }

    public IType Type => new TypeString();
}
