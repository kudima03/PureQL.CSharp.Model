namespace PureQL.CSharp.Model.RowExpressions;

public sealed record LessThanDatetimeRow
{
    public LessThanDatetimeRow(DatetimeNullableRow left, DatetimeNullableRow right)
    {
        Left = left;
        Right = right;
    }

    public DatetimeNullableRow Left { get; }

    public DatetimeNullableRow Right { get; }
}
