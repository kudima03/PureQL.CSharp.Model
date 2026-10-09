namespace PureQL.CSharp.Model.ProjectionExpressions;

public sealed record LessThanDateProjection
{
    public LessThanDateProjection(
        DateNullableProjection left,
        DateNullableProjection right
    )
    {
        Left = left;
        Right = right;
    }

    public DateNullableProjection Left { get; }

    public DateNullableProjection Right { get; }
}
