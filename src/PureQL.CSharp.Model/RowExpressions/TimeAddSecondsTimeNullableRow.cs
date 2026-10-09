namespace PureQL.CSharp.Model.RowExpressions;

public sealed record TimeAddSecondsTimeNullableRow
{
    public TimeAddSecondsTimeNullableRow(TimeNullableRow left, DecimalNullableRow right)
    {
        Left = left;
        Right = right;
    }

    public TimeNullableRow Left { get; }

    public DecimalNullableRow Right { get; }
}
