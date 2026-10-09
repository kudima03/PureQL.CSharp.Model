namespace PureQL.CSharp.Model.RowExpressions;

public sealed record DateDiffDaysIntegerRow
{
    public DateDiffDaysIntegerRow(DateRow left, DateRow right)
    {
        Left = left;
        Right = right;
    }

    public DateRow Left { get; }

    public DateRow Right { get; }
}
