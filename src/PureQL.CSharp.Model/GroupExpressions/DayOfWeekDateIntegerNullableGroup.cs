using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.GroupExpressions;

/// <summary>PureQL <c>dayOfWeek.date.integer.nullable@group</c>.</summary>
public sealed record DayOfWeekDateIntegerNullableGroup : IOperator
{
    public DayOfWeekDateIntegerNullableGroup(DeclaresDateNullableGroup operand)
    {
        Operand = operand;
    }

    public DeclaresDateNullableGroup Operand { get; }

    public IType Type => new TypeIntegerNullable();
}
