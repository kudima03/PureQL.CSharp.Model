namespace PureQL.CSharp.Model.GroupExpressions;

public sealed record DatetimeAddSecondsDatetimeGroup
{
    public DatetimeAddSecondsDatetimeGroup(DatetimeGroup left, DecimalGroup right)
    {
        Left = left;
        Right = right;
    }

    public DatetimeGroup Left { get; }

    public DecimalGroup Right { get; }
}
