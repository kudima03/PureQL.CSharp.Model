using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.TotalExpressions;

/// <summary>PureQL <c>startOfSecond.time@total</c>.</summary>
public sealed record StartOfSecondTimeTotal : IOperator
{
    public StartOfSecondTimeTotal(TimeTotal operand)
    {
        Operand = operand;
    }

    public TimeTotal Operand { get; }

    public IType Type => new TypeTime();
}
