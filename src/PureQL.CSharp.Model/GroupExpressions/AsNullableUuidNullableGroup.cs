using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.GroupExpressions;

/// <summary>PureQL <c>asNullable.uuid.nullable@group</c>.</summary>
public sealed record AsNullableUuidNullableGroup : IOperator
{
    public AsNullableUuidNullableGroup(UuidGroup operand)
    {
        Operand = operand;
    }

    public UuidGroup Operand { get; }

    public IType Type => new TypeUuidNullable();
}
