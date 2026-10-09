namespace PureQL.CSharp.Model.RowExpressions;

public sealed record TimeAddSecondsTimeRow
{
    public TimeAddSecondsTimeRow(TimeRow left, DecimalRow right)
    {
        Left = left;
        Right = right;
    }

    public TimeRow Left { get; }

    public DecimalRow Right { get; }
}
