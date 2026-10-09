namespace PureQL.CSharp.Model.RowExpressions;

public sealed record EqualBooleanRow
{
    public EqualBooleanRow(BooleanNullableRow left, BooleanNullableRow right)
    {
        Left = left;
        Right = right;
    }

    public BooleanNullableRow Left { get; }

    public BooleanNullableRow Right { get; }
}
