using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.GroupExpressions;

/// <summary>PureQL <c>day.date.integer@group</c>.</summary>
public sealed record DayDateIntegerGroup : IOperator
{
    public DayDateIntegerGroup(DateGroup operand)
    {
        Operand = operand;
    }

    public DateGroup Operand { get; }

    public IType Type => new TypeInteger();
}
