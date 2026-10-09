namespace PureQL.CSharp.Model.ProjectionExpressions;

public sealed record IntegerDivideIntegerNullableProjection
{
    public IntegerDivideIntegerNullableProjection(
        IntegerNullableProjection left,
        IntegerNullableProjection right
    )
    {
        Left = left;
        Right = right;
    }

    public IntegerNullableProjection Left { get; }

    public IntegerNullableProjection Right { get; }
}
