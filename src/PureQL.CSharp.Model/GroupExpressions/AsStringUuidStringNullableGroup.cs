using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.GroupExpressions;

/// <summary>PureQL <c>asString.uuid.string.nullable@group</c>.</summary>
public sealed record AsStringUuidStringNullableGroup : IOperator
{
    public AsStringUuidStringNullableGroup(DeclaresUuidNullableGroup operand)
    {
        Operand = operand;
    }

    public DeclaresUuidNullableGroup Operand { get; }

    public IType Type => new TypeStringNullable();
}
