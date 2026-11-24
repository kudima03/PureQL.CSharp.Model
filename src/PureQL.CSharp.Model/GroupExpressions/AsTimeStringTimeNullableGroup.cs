using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.GroupExpressions;

/// <summary>PureQL <c>asTime.string.time.nullable@group</c>.</summary>
public sealed record AsTimeStringTimeNullableGroup : IOperator
{
    public AsTimeStringTimeNullableGroup(DeclaresStringNullableGroup operand)
    {
        Operand = operand;
    }

    public DeclaresStringNullableGroup Operand { get; }

    public IType Type => new TypeTimeNullable();
}
