namespace PureQL.CSharp.Model.RowExpressions;

public sealed record IntegerDivideIntegerRow
{
    public IntegerDivideIntegerRow(IntegerRow left, IntegerRow right)
    {
        Left = left;
        Right = right;
    }

    public IntegerRow Left { get; }

    public IntegerRow Right { get; }
}
