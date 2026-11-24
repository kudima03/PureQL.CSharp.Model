using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.GroupExpressions;

/// <summary>PureQL <c>asNullable.time.nullable@group</c>.</summary>
public sealed record AsNullableTimeNullableGroup : IOperator
{
    public AsNullableTimeNullableGroup(TimeGroup operand)
    {
        Operand = operand;
    }

    public TimeGroup Operand { get; }

    public IType Type => new TypeTimeNullable();
}
