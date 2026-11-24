using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.TotalExpressions;

/// <summary>PureQL <c>position.integer@total</c>.</summary>
public sealed record PositionIntegerTotal : IOperator
{
    public PositionIntegerTotal(
        StringTotal operand,
        StringTotal pattern,
        IntegerTotal? start = null
    )
    {
        Operand = operand;
        Pattern = pattern;
        Start = start;
    }

    public StringTotal Operand { get; }

    public StringTotal Pattern { get; }

    public IntegerTotal? Start { get; }

    public IType Type => new TypeInteger();
}
