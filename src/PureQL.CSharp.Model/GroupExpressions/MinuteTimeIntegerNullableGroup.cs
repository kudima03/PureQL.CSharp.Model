using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.GroupExpressions;

/// <summary>PureQL <c>minute.time.integer.nullable@group</c>.</summary>
public sealed record MinuteTimeIntegerNullableGroup : IOperator
{
    public MinuteTimeIntegerNullableGroup(DeclaresTimeNullableGroup operand)
    {
        Operand = operand;
    }

    public DeclaresTimeNullableGroup Operand { get; }

    public IType Type => new TypeIntegerNullable();
}
