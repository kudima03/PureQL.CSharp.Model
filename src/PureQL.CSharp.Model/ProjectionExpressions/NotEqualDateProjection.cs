namespace PureQL.CSharp.Model.ProjectionExpressions;

public sealed record NotEqualDateProjection
{
    public NotEqualDateProjection(
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
