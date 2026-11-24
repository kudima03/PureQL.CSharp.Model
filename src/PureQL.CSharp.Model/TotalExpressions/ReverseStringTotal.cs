using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.TotalExpressions;

/// <summary>PureQL <c>reverse.string@total</c>.</summary>
public sealed record ReverseStringTotal : IOperator
{
    public ReverseStringTotal(StringTotal operand)
    {
        Operand = operand;
    }

    public StringTotal Operand { get; }

    public IType Type => new TypeString();
}
