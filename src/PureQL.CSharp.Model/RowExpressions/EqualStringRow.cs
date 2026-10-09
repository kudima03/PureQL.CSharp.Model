namespace PureQL.CSharp.Model.RowExpressions;

public sealed record EqualStringRow
{
    public EqualStringRow(StringNullableRow left, StringNullableRow right)
    {
        Left = left;
        Right = right;
    }

    public StringNullableRow Left { get; }

    public StringNullableRow Right { get; }
}
