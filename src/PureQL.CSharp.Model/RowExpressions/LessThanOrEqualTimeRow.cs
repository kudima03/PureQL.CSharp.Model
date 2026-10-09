namespace PureQL.CSharp.Model.RowExpressions;

public sealed record LessThanOrEqualTimeRow
{
    public LessThanOrEqualTimeRow(TimeNullableRow left, TimeNullableRow right)
    {
        Left = left;
        Right = right;
    }

    public TimeNullableRow Left { get; }

    public TimeNullableRow Right { get; }
}
