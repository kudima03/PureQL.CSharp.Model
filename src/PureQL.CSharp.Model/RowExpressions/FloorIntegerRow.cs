namespace PureQL.CSharp.Model.RowExpressions;

public sealed record FloorIntegerRow
{
    public FloorIntegerRow(DecimalRow value)
    {
        Value = value;
    }

    public DecimalRow Value { get; }
}
