using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.ProjectionExpressions;

/// <summary>PureQL <c>nullIfEqual.uuid.nullable@projection</c>.</summary>
public sealed record NullIfEqualUuidNullableProjection : IOperator
{
    public NullIfEqualUuidNullableProjection(
        UuidNullableProjection left,
        UuidNullableProjection right
    )
    {
        Left = left;
        Right = right;
    }

    public UuidNullableProjection Left { get; }

    public UuidNullableProjection Right { get; }

    public IType Type => new TypeUuidNullable();
}
