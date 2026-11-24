using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.GroupExpressions;

/// <summary>PureQL <c>startOfWeek.date.nullable@group</c>.</summary>
public sealed record StartOfWeekDateNullableGroup : IOperator
{
    public StartOfWeekDateNullableGroup(DeclaresDateNullableGroup operand)
    {
        Operand = operand;
    }

    public DeclaresDateNullableGroup Operand { get; }

    public IType Type => new TypeDateNullable();
}
