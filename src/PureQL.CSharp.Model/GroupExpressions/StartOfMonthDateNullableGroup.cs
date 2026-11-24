using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.GroupExpressions;

/// <summary>PureQL <c>startOfMonth.date.nullable@group</c>.</summary>
public sealed record StartOfMonthDateNullableGroup : IOperator
{
    public StartOfMonthDateNullableGroup(DeclaresDateNullableGroup operand)
    {
        Operand = operand;
    }

    public DeclaresDateNullableGroup Operand { get; }

    public IType Type => new TypeDateNullable();
}
