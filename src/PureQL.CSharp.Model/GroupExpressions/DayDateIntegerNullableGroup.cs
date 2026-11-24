using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.GroupExpressions;

/// <summary>PureQL <c>day.date.integer.nullable@group</c>.</summary>
public sealed record DayDateIntegerNullableGroup : IOperator
{
    public DayDateIntegerNullableGroup(DeclaresDateNullableGroup operand)
    {
        Operand = operand;
    }

    public DeclaresDateNullableGroup Operand { get; }

    public IType Type => new TypeIntegerNullable();
}
