namespace PureQL.CSharp.Model.ProjectionExpressions;

public sealed record DatetimeDiffSecondsDecimalProjection
{
    public DatetimeDiffSecondsDecimalProjection(
        DatetimeProjection left,
        DatetimeProjection right
    )
    {
        Left = left;
        Right = right;
    }

    public DatetimeProjection Left { get; }

    public DatetimeProjection Right { get; }
}
