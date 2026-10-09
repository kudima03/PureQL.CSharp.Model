namespace PureQL.CSharp.Model.GroupExpressions;

public sealed record TimeDiffSecondsDecimalGroup
{
    public TimeDiffSecondsDecimalGroup(TimeGroup left, TimeGroup right)
    {
        Left = left;
        Right = right;
    }

    public TimeGroup Left { get; }

    public TimeGroup Right { get; }
}
