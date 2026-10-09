namespace PureQL.CSharp.Model.RowExpressions;

public sealed record ModuloIntegerRow
{
    public ModuloIntegerRow(IntegerRow left, IntegerRow right)
    {
        Left = left;
        Right = right;
    }

    public IntegerRow Left { get; }

    public IntegerRow Right { get; }
}
