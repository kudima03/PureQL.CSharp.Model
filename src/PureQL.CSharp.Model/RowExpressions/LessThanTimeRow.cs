namespace PureQL.CSharp.Model.RowExpressions;

public sealed record LessThanTimeRow
{
    public LessThanTimeRow(TimeNullableRow left, TimeNullableRow right)
    {
        Left = left;
        Right = right;
    }

    public TimeNullableRow Left { get; }

    public TimeNullableRow Right { get; }
}
