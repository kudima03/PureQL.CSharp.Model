using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.TotalExpressions;

/// <summary>PureQL <c>upper.string@total</c>.</summary>
public sealed record UpperStringTotal : IOperator
{
    public UpperStringTotal(StringTotal operand)
    {
        Operand = operand;
    }

    public StringTotal Operand { get; }

    public IType Type => new TypeString();
}
