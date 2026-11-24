using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.TotalExpressions;

/// <summary>PureQL <c>startOfHour.time@total</c>.</summary>
public sealed record StartOfHourTimeTotal : IOperator
{
    public StartOfHourTimeTotal(TimeTotal operand)
    {
        Operand = operand;
    }

    public TimeTotal Operand { get; }

    public IType Type => new TypeTime();
}
