using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.ProjectionExpressions;

/// <summary>PureQL <c>notEqual.uuid@projection</c>.</summary>
public sealed record NotEqualUuidProjection : IOperator
{
    public NotEqualUuidProjection(
        UuidNullableProjection left,
        UuidNullableProjection right
    )
    {
        Left = left;
        Right = right;
    }

    public UuidNullableProjection Left { get; }

    public UuidNullableProjection Right { get; }

    public IType Type => new TypeBoolean();
}
