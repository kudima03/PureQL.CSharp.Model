namespace PureQL.CSharp.Model.RowExpressions;

public sealed record LessThanDecimalRow
{
    public LessThanDecimalRow(DecimalNullableRow left, DecimalNullableRow right)
    {
        Left = left;
        Right = right;
    }

    public DecimalNullableRow Left { get; }

    public DecimalNullableRow Right { get; }
}
