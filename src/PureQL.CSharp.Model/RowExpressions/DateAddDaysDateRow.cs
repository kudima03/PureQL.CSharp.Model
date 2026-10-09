namespace PureQL.CSharp.Model.RowExpressions;

public sealed record DateAddDaysDateRow
{
    public DateAddDaysDateRow(DateRow left, IntegerRow right)
    {
        Left = left;
        Right = right;
    }

    public DateRow Left { get; }

    public IntegerRow Right { get; }
}
