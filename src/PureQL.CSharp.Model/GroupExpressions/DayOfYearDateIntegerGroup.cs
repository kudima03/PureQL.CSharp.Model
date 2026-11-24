using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.GroupExpressions;

/// <summary>PureQL <c>dayOfYear.date.integer@group</c>.</summary>
public sealed record DayOfYearDateIntegerGroup : IOperator
{
    public DayOfYearDateIntegerGroup(DateGroup operand)
    {
        Operand = operand;
    }

    public DateGroup Operand { get; }

    public IType Type => new TypeInteger();
}
