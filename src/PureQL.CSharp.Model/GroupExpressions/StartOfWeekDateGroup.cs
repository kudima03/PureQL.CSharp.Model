using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.GroupExpressions;

/// <summary>PureQL <c>startOfWeek.date@group</c>.</summary>
public sealed record StartOfWeekDateGroup : IOperator
{
    public StartOfWeekDateGroup(DateGroup operand)
    {
        Operand = operand;
    }

    public DateGroup Operand { get; }

    public IType Type => new TypeDate();
}
