using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.GroupExpressions;

/// <summary>PureQL <c>hour.time.integer.nullable@group</c>.</summary>
public sealed record HourTimeIntegerNullableGroup : IOperator
{
    public HourTimeIntegerNullableGroup(DeclaresTimeNullableGroup operand)
    {
        Operand = operand;
    }

    public DeclaresTimeNullableGroup Operand { get; }

    public IType Type => new TypeIntegerNullable();
}
