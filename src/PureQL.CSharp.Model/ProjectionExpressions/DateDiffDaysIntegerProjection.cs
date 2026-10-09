namespace PureQL.CSharp.Model.ProjectionExpressions;

public sealed record DateDiffDaysIntegerProjection
{
    public DateDiffDaysIntegerProjection(DateProjection left, DateProjection right)
    {
        Left = left;
        Right = right;
    }

    public DateProjection Left { get; }

    public DateProjection Right { get; }
}
