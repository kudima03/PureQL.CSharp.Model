namespace PureQL.CSharp.Model.RowExpressions;

public sealed record CeilingIntegerNullableRow
{
    public CeilingIntegerNullableRow(DecimalNullableRow value)
    {
        Value = value;
    }

    public DecimalNullableRow Value { get; }
}
