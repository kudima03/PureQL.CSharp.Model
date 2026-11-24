using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.GroupExpressions;

/// <summary>PureQL <c>startOfMinute.time.nullable@group</c>.</summary>
public sealed record StartOfMinuteTimeNullableGroup : IOperator
{
    public StartOfMinuteTimeNullableGroup(DeclaresTimeNullableGroup operand)
    {
        Operand = operand;
    }

    public DeclaresTimeNullableGroup Operand { get; }

    public IType Type => new TypeTimeNullable();
}
