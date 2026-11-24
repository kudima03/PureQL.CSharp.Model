using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.TotalExpressions;

/// <summary>PureQL <c>hour.time.integer@total</c>.</summary>
public sealed record HourTimeIntegerTotal : IOperator
{
    public HourTimeIntegerTotal(TimeTotal operand)
    {
        Operand = operand;
    }

    public TimeTotal Operand { get; }

    public IType Type => new TypeInteger();
}
