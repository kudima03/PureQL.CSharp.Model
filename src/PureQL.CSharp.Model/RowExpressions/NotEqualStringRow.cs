namespace PureQL.CSharp.Model.RowExpressions;

public sealed record NotEqualStringRow
{
    public NotEqualStringRow(StringNullableRow left, StringNullableRow right)
    {
        Left = left;
        Right = right;
    }

    public StringNullableRow Left { get; }

    public StringNullableRow Right { get; }
}
