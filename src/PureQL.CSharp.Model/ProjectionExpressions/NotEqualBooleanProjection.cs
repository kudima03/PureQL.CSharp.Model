namespace PureQL.CSharp.Model.ProjectionExpressions;

public sealed record NotEqualBooleanProjection
{
    public NotEqualBooleanProjection(
        BooleanNullableProjection left,
        BooleanNullableProjection right
    )
    {
        Left = left;
        Right = right;
    }

    public BooleanNullableProjection Left { get; }

    public BooleanNullableProjection Right { get; }
}
