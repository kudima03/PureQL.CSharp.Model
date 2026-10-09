namespace PureQL.CSharp.Model.RowExpressions;

public sealed record NotEqualTimeRow
{
    public NotEqualTimeRow(TimeNullableRow left, TimeNullableRow right)
    {
        Left = left;
        Right = right;
    }

    public TimeNullableRow Left { get; }

    public TimeNullableRow Right { get; }
}
