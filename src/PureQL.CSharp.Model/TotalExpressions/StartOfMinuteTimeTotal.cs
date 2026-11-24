using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.TotalExpressions;

/// <summary>PureQL <c>startOfMinute.time@total</c>.</summary>
public sealed record StartOfMinuteTimeTotal : IOperator
{
    public StartOfMinuteTimeTotal(TimeTotal operand)
    {
        Operand = operand;
    }

    public TimeTotal Operand { get; }

    public IType Type => new TypeTime();
}
