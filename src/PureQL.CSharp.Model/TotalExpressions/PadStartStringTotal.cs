using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.TotalExpressions;

/// <summary>PureQL <c>padStart.string@total</c>.</summary>
public sealed record PadStartStringTotal : IOperator
{
    public PadStartStringTotal(StringTotal operand, IntegerTotal length, StringTotal fill)
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
