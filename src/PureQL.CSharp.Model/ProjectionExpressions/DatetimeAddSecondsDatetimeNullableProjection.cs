namespace PureQL.CSharp.Model.ProjectionExpressions;

public sealed record DatetimeAddSecondsDatetimeNullableProjection
{
    public DatetimeAddSecondsDatetimeNullableProjection(
        DatetimeNullableProjection left,
        DecimalNullableProjection right
    )
    {
        Left = left;
        Right = right;
    }

    public DatetimeNullableProjection Left { get; }

    public DecimalNullableProjection Right { get; }
}
