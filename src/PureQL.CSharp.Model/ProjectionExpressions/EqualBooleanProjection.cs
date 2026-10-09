namespace PureQL.CSharp.Model.ProjectionExpressions;

public sealed record EqualBooleanProjection
{
    public EqualBooleanProjection(
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
