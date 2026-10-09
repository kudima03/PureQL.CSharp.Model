namespace PureQL.CSharp.Model.ProjectionExpressions;

public sealed record IntegerDivideIntegerProjection
{
    public IntegerDivideIntegerProjection(IntegerProjection left, IntegerProjection right)
    {
        Left = left;
        Right = right;
    }

    public IntegerProjection Left { get; }

    public IntegerProjection Right { get; }
}
