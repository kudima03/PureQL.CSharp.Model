using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.TotalExpressions;

/// <summary>PureQL <c>dayOfWeek.date.integer@total</c>.</summary>
public sealed record DayOfWeekDateIntegerTotal : IOperator
{
    public DayOfWeekDateIntegerTotal(DateTotal operand)
    {
        Operand = operand;
    }

    public DateTotal Operand { get; }

    public IType Type => new TypeInteger();
}
