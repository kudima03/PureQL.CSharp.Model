namespace PureQL.CSharp.Model.RowExpressions;

public sealed record EqualDateRow
{
    public EqualDateRow(DateNullableRow left, DateNullableRow right)
    {
        Left = left;
        Right = right;
    }

    public DateNullableRow Left { get; }

    public DateNullableRow Right { get; }
}
