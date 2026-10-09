namespace PureQL.CSharp.Model.ProjectionExpressions;

public sealed record GreaterThanOrEqualDateProjection
{
    public GreaterThanOrEqualDateProjection(
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
