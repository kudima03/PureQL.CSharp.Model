namespace PureQL.CSharp.Model.ProjectionExpressions;

public sealed record NotEqualUuidProjection
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
}
