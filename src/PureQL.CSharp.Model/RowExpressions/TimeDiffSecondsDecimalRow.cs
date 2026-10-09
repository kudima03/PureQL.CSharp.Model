namespace PureQL.CSharp.Model.RowExpressions;

public sealed record TimeDiffSecondsDecimalRow
{
    public TimeDiffSecondsDecimalRow(TimeRow left, TimeRow right)
    {
        Left = left;
        Right = right;
    }

    public TimeRow Left { get; }

    public TimeRow Right { get; }
}
