namespace PureQL.CSharp.Model.ProjectionExpressions;

public sealed record DatetimeAddSecondsDatetimeProjection
{
    public DatetimeAddSecondsDatetimeProjection(
        DatetimeProjection left,
        DecimalProjection right
    )
    {
        Left = left;
        Right = right;
    }

    public DatetimeProjection Left { get; }

    public DecimalProjection Right { get; }
}
