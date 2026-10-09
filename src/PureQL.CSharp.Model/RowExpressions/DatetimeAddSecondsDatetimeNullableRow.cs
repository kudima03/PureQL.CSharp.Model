namespace PureQL.CSharp.Model.RowExpressions;

public sealed record DatetimeAddSecondsDatetimeNullableRow
{
    public DatetimeAddSecondsDatetimeNullableRow(
        DatetimeNullableRow left,
        DecimalNullableRow right
    )
    {
        Left = left;
        Right = right;
    }

    public DatetimeNullableRow Left { get; }

    public DecimalNullableRow Right { get; }
}
