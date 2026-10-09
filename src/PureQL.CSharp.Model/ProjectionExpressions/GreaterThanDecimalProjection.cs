namespace PureQL.CSharp.Model.ProjectionExpressions;

public sealed record GreaterThanDecimalProjection
{
    public GreaterThanDecimalProjection(
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
