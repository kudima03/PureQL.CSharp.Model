using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.TotalExpressions;

/// <summary>PureQL <c>minute.time.integer@total</c>.</summary>
public sealed record MinuteTimeIntegerTotal : IOperator
{
    public MinuteTimeIntegerTotal(TimeTotal operand)
    {
        Operand = operand;
    }

    public TimeTotal Operand { get; }

    public IType Type => new TypeInteger();
}
