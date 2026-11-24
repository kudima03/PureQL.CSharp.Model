using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.TotalExpressions;

/// <summary>PureQL <c>timeAddSeconds.time@total</c>.</summary>
public sealed record TimeAddSecondsTimeTotal : IOperator
{
    public TimeAddSecondsTimeTotal(TimeTotal operand, DecimalTotal seconds)
    {
        Operand = operand;
        Seconds = seconds;
    }

    public TimeTotal Operand { get; }

    public DecimalTotal Seconds { get; }

    public IType Type => new TypeTime();
}
