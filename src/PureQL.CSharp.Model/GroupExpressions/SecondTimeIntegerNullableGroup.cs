using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.GroupExpressions;

/// <summary>PureQL <c>second.time.integer.nullable@group</c>.</summary>
public sealed record SecondTimeIntegerNullableGroup : IOperator
{
    public SecondTimeIntegerNullableGroup(DeclaresTimeNullableGroup operand)
    {
        Operand = operand;
    }

    public DeclaresTimeNullableGroup Operand { get; }

    public IType Type => new TypeIntegerNullable();
}
