namespace PureQL.CSharp.Model.GroupExpressions;

public sealed record DatetimeDiffSecondsDecimalGroup
{
    public DatetimeDiffSecondsDecimalGroup(DatetimeGroup left, DatetimeGroup right)
    {
        Left = left;
        Right = right;
    }

    public DatetimeGroup Left { get; }

    public DatetimeGroup Right { get; }
}
