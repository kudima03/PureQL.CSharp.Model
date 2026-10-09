namespace PureQL.CSharp.Model.RowExpressions;

public sealed record EqualUuidRow
{
    public EqualUuidRow(UuidNullableRow left, UuidNullableRow right)
    {
        Left = left;
        Right = right;
    }

    public UuidNullableRow Left { get; }

    public UuidNullableRow Right { get; }
}
