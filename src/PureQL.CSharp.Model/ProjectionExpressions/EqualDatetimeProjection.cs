namespace PureQL.CSharp.Model.ProjectionExpressions;

public sealed record EqualDatetimeProjection
{
    public EqualDatetimeProjection(
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
