namespace PureQL.CSharp.Model.RowExpressions;

public sealed record RoundIntegerNullableRow
{
    public RoundIntegerNullableRow(DecimalNullableRow value)
    {
        Value = value;
    }

    public DecimalNullableRow Value { get; }
}
