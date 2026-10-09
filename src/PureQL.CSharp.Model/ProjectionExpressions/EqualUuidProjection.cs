namespace PureQL.CSharp.Model.ProjectionExpressions;

public sealed record EqualUuidProjection
{
    public EqualUuidProjection(UuidNullableProjection left, UuidNullableProjection right)
    {
        Left = left;
        Right = right;
    }

    public UuidNullableProjection Left { get; }

    public UuidNullableProjection Right { get; }
}
