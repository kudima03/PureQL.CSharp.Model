namespace PureQL.CSharp.Model.ProjectionExpressions;

public sealed record DatetimeDiffSecondsDecimalNullableProjection
{
    public DatetimeDiffSecondsDecimalNullableProjection(
        DatetimeNullableProjection left,
        DatetimeNullableProjection right
    )
    {
        Left = left;
        Right = right;
    }

    public DatetimeNullableProjection Left { get; }

    public DatetimeNullableProjection Right { get; }
}
