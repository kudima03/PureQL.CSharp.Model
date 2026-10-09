namespace PureQL.CSharp.Model.ProjectionExpressions;

public sealed record EqualDecimalProjection
{
    public EqualDecimalProjection(
        DecimalNullableProjection left,
        DecimalNullableProjection right
    )
    {
        Left = left;
        Right = right;
    }

    public DecimalNullableProjection Left { get; }

    public DecimalNullableProjection Right { get; }
}
