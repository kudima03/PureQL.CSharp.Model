namespace PureQL.CSharp.Model.RowExpressions;

public sealed record GreaterThanDecimalRow
{
    public GreaterThanDecimalRow(DecimalNullableRow left, DecimalNullableRow right)
    {
        Left = left;
        Right = right;
    }

    public DecimalNullableRow Left { get; }

    public DecimalNullableRow Right { get; }
}
