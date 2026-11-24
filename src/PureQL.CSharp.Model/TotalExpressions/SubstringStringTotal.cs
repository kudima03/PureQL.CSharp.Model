using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.TotalExpressions;

/// <summary>PureQL <c>substring.string@total</c>.</summary>
public sealed record SubstringStringTotal : IOperator
{
    public SubstringStringTotal(
        StringTotal operand,
        IntegerTotal start,
        IntegerTotal? length = null
    )
    {
        Operand = operand;
        Start = start;
        Length = length;
    }

    public StringTotal Operand { get; }

    public IntegerTotal Start { get; }

    public IntegerTotal? Length { get; }

    public IType Type => new TypeString();
}
