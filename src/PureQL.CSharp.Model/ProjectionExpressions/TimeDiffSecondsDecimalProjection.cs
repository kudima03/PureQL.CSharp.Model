namespace PureQL.CSharp.Model.ProjectionExpressions;

public sealed record TimeDiffSecondsDecimalProjection
{
    public TimeDiffSecondsDecimalProjection(TimeProjection left, TimeProjection right)
    {
        Left = left;
        Right = right;
    }

    public TimeProjection Left { get; }

    public TimeProjection Right { get; }
}
