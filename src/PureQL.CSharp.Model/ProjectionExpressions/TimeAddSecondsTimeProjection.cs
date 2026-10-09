namespace PureQL.CSharp.Model.ProjectionExpressions;

public sealed record TimeAddSecondsTimeProjection
{
    public TimeAddSecondsTimeProjection(TimeProjection left, DecimalProjection right)
    {
        Left = left;
        Right = right;
    }

    public TimeProjection Left { get; }

    public DecimalProjection Right { get; }
}
