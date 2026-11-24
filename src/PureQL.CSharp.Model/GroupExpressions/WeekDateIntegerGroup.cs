using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.GroupExpressions;

/// <summary>PureQL <c>week.date.integer@group</c>.</summary>
public sealed record WeekDateIntegerGroup : IOperator
{
    public WeekDateIntegerGroup(DateGroup operand)
    {
        Operand = operand;
    }

    public DateGroup Operand { get; }

    public IType Type => new TypeInteger();
}
