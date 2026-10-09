namespace PureQL.CSharp.Model.RowExpressions;

public sealed record FloorIntegerNullableRow
{
    public FloorIntegerNullableRow(DecimalNullableRow value)
    {
        Value = value;
    }

    public DecimalNullableRow Value { get; }
}
