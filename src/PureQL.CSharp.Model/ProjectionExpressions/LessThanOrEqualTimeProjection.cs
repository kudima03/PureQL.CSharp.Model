namespace PureQL.CSharp.Model.ProjectionExpressions;

public sealed record LessThanOrEqualTimeProjection
{
    public LessThanOrEqualTimeProjection(
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
