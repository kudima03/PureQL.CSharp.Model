namespace PureQL.CSharp.Model.ProjectionExpressions;

public sealed record ModuloIntegerNullableProjection
{
    public ModuloIntegerNullableProjection(
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
