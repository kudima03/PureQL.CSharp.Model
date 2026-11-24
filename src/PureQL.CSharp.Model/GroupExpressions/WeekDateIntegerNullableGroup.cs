using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.GroupExpressions;

/// <summary>PureQL <c>week.date.integer.nullable@group</c>.</summary>
public sealed record WeekDateIntegerNullableGroup : IOperator
{
    public WeekDateIntegerNullableGroup(DeclaresDateNullableGroup operand)
    {
        Operand = operand;
    }

    public DeclaresDateNullableGroup Operand { get; }

    public IType Type => new TypeIntegerNullable();
}
