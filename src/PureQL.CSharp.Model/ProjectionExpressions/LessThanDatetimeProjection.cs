namespace PureQL.CSharp.Model.ProjectionExpressions;

public sealed record LessThanDatetimeProjection
{
    public LessThanDatetimeProjection(
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
