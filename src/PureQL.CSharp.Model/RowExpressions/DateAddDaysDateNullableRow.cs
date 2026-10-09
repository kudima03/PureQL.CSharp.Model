namespace PureQL.CSharp.Model.RowExpressions;

public sealed record DateAddDaysDateNullableRow
{
    public DateAddDaysDateNullableRow(DateNullableRow left, IntegerNullableRow right)
    {
        Left = left;
        Right = right;
    }

    public DateNullableRow Left { get; }

    public IntegerNullableRow Right { get; }
}
