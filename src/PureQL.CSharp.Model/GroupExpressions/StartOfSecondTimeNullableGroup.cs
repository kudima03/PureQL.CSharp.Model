using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.GroupExpressions;

/// <summary>PureQL <c>startOfSecond.time.nullable@group</c>.</summary>
public sealed record StartOfSecondTimeNullableGroup : IOperator
{
    public StartOfSecondTimeNullableGroup(DeclaresTimeNullableGroup operand)
    {
        Operand = operand;
    }

    public DeclaresTimeNullableGroup Operand { get; }

    public IType Type => new TypeTimeNullable();
}
