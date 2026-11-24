using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.TotalExpressions;

/// <summary>PureQL <c>padEnd.string@total</c>.</summary>
public sealed record PadEndStringTotal : IOperator
{
    public PadEndStringTotal(StringTotal operand, IntegerTotal length, StringTotal fill)
    {
        Operand = operand;
        Length = length;
        Fill = fill;
    }

    public StringTotal Operand { get; }

    public IntegerTotal Length { get; }

    public StringTotal Fill { get; }

    public IType Type => new TypeString();
}
