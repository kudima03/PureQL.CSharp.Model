using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.ProjectionExpressions;

/// <summary>PureQL <c>lessThanOrEqual.uuid@projection</c>.</summary>
public sealed record LessThanOrEqualUuidProjection : IOperator
{
    public LessThanOrEqualUuidProjection(
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
