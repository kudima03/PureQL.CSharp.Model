namespace PureQL.CSharp.Model.GroupExpressions;

public sealed record TimeAddSecondsTimeGroup
{
    public TimeAddSecondsTimeGroup(TimeGroup left, DecimalGroup right)
    {
        Left = left;
        Right = right;
    }

    public TimeGroup Left { get; }

    public DecimalGroup Right { get; }
}
