namespace PureQL.CSharp.Model.RowExpressions;

public sealed record DatetimeDiffSecondsDecimalRow
{
    public DatetimeDiffSecondsDecimalRow(DatetimeRow left, DatetimeRow right)
    {
        Left = left;
        Right = right;
    }

    public DatetimeRow Left { get; }

    public DatetimeRow Right { get; }
}
