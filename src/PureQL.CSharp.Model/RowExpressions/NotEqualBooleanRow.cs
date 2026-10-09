namespace PureQL.CSharp.Model.RowExpressions;

public sealed record NotEqualBooleanRow
{
    public NotEqualBooleanRow(BooleanNullableRow left, BooleanNullableRow right)
    {
        Left = left;
        Right = right;
    }

    public BooleanNullableRow Left { get; }

    public BooleanNullableRow Right { get; }
}
