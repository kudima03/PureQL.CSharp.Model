namespace PureQL.CSharp.Model.ProjectionExpressions;

public sealed record TimeAddSecondsTimeNullableProjection
{
    public TimeAddSecondsTimeNullableProjection(
        TimeNullableProjection left,
        DecimalNullableProjection right
    )
    {
        Left = left;
        Right = right;
    }

    public TimeNullableProjection Left { get; }

    public DecimalNullableProjection Right { get; }
}
