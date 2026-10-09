namespace PureQL.CSharp.Model.RowExpressions;

public sealed record LessThanStringRow
{
    public LessThanStringRow(StringNullableRow left, StringNullableRow right)
    {
        Left = left;
        Right = right;
    }

    public StringNullableRow Left { get; }

    public StringNullableRow Right { get; }
}
