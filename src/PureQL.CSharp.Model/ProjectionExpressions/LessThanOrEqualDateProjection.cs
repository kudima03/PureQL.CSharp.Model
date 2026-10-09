namespace PureQL.CSharp.Model.ProjectionExpressions;

public sealed record LessThanOrEqualDateProjection
{
    public LessThanOrEqualDateProjection(
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
