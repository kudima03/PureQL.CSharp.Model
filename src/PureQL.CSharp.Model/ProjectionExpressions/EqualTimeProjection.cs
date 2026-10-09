namespace PureQL.CSharp.Model.ProjectionExpressions;

public sealed record EqualTimeProjection
{
    public EqualTimeProjection(TimeNullableProjection left, TimeNullableProjection right)
    {
        Left = left;
        Right = right;
    }

    public TimeNullableProjection Left { get; }

    public TimeNullableProjection Right { get; }
}
