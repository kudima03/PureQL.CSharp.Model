namespace PureQL.CSharp.Model.ProjectionExpressions;

public sealed record ModuloIntegerProjection
{
    public ModuloIntegerProjection(IntegerProjection left, IntegerProjection right)
    {
        Left = left;
        Right = right;
    }

    public IntegerProjection Left { get; }

    public IntegerProjection Right { get; }
}
