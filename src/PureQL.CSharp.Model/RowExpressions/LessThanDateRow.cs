namespace PureQL.CSharp.Model.RowExpressions;

public sealed record LessThanDateRow
{
    public LessThanDateRow(DateNullableRow left, DateNullableRow right)
    {
        Left = left;
        Right = right;
    }

    public DateNullableRow Left { get; }

    public DateNullableRow Right { get; }
}
