namespace PureQL.CSharp.Model.RowExpressions;

public sealed record LessThanOrEqualDatetimeRow
{
    public LessThanOrEqualDatetimeRow(DatetimeNullableRow left, DatetimeNullableRow right)
    {
        Left = left;
        Right = right;
    }

    public DatetimeNullableRow Left { get; }

    public DatetimeNullableRow Right { get; }
}
