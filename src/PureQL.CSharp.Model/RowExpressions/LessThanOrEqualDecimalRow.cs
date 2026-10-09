namespace PureQL.CSharp.Model.RowExpressions;

public sealed record LessThanOrEqualDecimalRow
{
    public LessThanOrEqualDecimalRow(DecimalNullableRow left, DecimalNullableRow right)
    {
        Left = left;
        Right = right;
    }

    public DecimalNullableRow Left { get; }

    public DecimalNullableRow Right { get; }
}
