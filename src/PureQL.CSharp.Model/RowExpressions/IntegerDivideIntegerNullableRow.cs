namespace PureQL.CSharp.Model.RowExpressions;

public sealed record IntegerDivideIntegerNullableRow
{
    public IntegerDivideIntegerNullableRow(
        IntegerNullableRow left,
        IntegerNullableRow right
    )
    {
        Left = left;
        Right = right;
    }

    public IntegerNullableRow Left { get; }

    public IntegerNullableRow Right { get; }
}
