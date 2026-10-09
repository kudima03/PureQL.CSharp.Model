namespace PureQL.CSharp.Model.RowExpressions;

public sealed record DatetimeAddSecondsDatetimeRow
{
    public DatetimeAddSecondsDatetimeRow(DatetimeRow left, DecimalRow right)
    {
        Left = left;
        Right = right;
    }

    public DatetimeRow Left { get; }

    public DecimalRow Right { get; }
}
