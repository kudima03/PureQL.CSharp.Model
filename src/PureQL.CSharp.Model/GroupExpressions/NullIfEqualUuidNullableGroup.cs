using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.GroupExpressions;

/// <summary>PureQL <c>nullIfEqual.uuid.nullable@group</c>.</summary>
public sealed record NullIfEqualUuidNullableGroup : IOperator
{
    public NullIfEqualUuidNullableGroup(UuidNullableGroup left, UuidNullableGroup right)
    {
        Left = left;
        Right = right;
    }

    public UuidNullableGroup Left { get; }

    public UuidNullableGroup Right { get; }

    public IType Type => new TypeUuidNullable();
}
