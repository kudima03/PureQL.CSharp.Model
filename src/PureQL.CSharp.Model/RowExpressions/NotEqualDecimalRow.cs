namespace PureQL.CSharp.Model.RowExpressions;

public sealed record NotEqualDecimalRow
{
    public NotEqualDecimalRow(DecimalNullableRow left, DecimalNullableRow right)
    {
        Left = left;
        Right = right;
    }

    public DecimalNullableRow Left { get; }

    public DecimalNullableRow Right { get; }
}
