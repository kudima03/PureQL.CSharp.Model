using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.GroupExpressions;

/// <summary>PureQL <c>asUuid.uuid.nullable@group</c>.</summary>
public sealed record AsUuidUuidNullableGroup : IOperator
{
    public AsUuidUuidNullableGroup(DeclaresStringNullableGroup operand)
    {
        Operand = operand;
    }

    public DeclaresStringNullableGroup Operand { get; }

    public IType Type => new TypeUuidNullable();
}
