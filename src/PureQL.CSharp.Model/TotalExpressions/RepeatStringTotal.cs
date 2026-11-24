using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.TotalExpressions;

/// <summary>PureQL <c>repeat.string@total</c>.</summary>
public sealed record RepeatStringTotal : IOperator
{
    public RepeatStringTotal(StringTotal operand, IntegerTotal count)
    {
        Operand = operand;
        Count = count;
    }

    public StringTotal Operand { get; }

    public IntegerTotal Count { get; }

    public IType Type => new TypeString();
}
