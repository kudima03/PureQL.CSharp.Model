using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.GroupExpressions;

/// <summary>PureQL <c>dayOfWeek.date.integer@group</c>.</summary>
public sealed record DayOfWeekDateIntegerGroup : IOperator
{
    public DayOfWeekDateIntegerGroup(DateGroup operand)
    {
        Operand = operand;
    }

    public DateGroup Operand { get; }

    public IType Type => new TypeInteger();
}
