namespace PureQL.CSharp.Model.ProjectionExpressions;

public sealed record GreaterThanOrEqualTimeProjection
{
    public GreaterThanOrEqualTimeProjection(
        TimeNullableProjection left,
        TimeNullableProjection right
    )
    {
        Left = left;
        Right = right;
    }

    public TimeNullableProjection Left { get; }

    public TimeNullableProjection Right { get; }
}
