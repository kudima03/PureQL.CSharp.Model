using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.GroupExpressions;

/// <summary>PureQL <c>weekYear.date.integer@group</c>.</summary>
public sealed record WeekYearDateIntegerGroup : IOperator
{
    public WeekYearDateIntegerGroup(DateGroup operand)
    {
        Operand = operand;
    }

    public DateGroup Operand { get; }

    public IType Type => new TypeInteger();
}
