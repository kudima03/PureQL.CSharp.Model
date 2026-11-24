using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.TotalExpressions;

/// <summary>PureQL <c>microsecond.time.integer@total</c>.</summary>
public sealed record MicrosecondTimeIntegerTotal : IOperator
{
    public MicrosecondTimeIntegerTotal(TimeTotal operand)
    {
        Operand = operand;
    }

    public TimeTotal Operand { get; }

    public IType Type => new TypeInteger();
}
