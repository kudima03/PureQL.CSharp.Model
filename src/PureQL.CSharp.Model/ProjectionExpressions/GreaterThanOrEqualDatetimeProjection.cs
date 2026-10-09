namespace PureQL.CSharp.Model.ProjectionExpressions;

public sealed record GreaterThanOrEqualDatetimeProjection
{
    public GreaterThanOrEqualDatetimeProjection(
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
