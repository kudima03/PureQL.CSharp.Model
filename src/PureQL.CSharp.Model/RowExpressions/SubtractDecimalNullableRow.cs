namespace PureQL.CSharp.Model.RowExpressions;

public sealed record SubtractDecimalNullableRow
{
    public SubtractDecimalNullableRow(IEnumerable<DecimalNullableRow> values)
    {
        Values = values;
    }

    public IEnumerable<DecimalNullableRow> Values { get; }
}
