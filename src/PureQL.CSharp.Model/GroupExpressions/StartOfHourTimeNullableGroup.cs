using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.GroupExpressions;

/// <summary>PureQL <c>startOfHour.time.nullable@group</c>.</summary>
public sealed record StartOfHourTimeNullableGroup : IOperator
{
    public StartOfHourTimeNullableGroup(DeclaresTimeNullableGroup operand)
    {
        Operand = operand;
    }

    public DeclaresTimeNullableGroup Operand { get; }

    public IType Type => new TypeTimeNullable();
}
