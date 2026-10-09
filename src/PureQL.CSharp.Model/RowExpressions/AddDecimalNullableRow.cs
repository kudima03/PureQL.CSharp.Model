namespace PureQL.CSharp.Model.RowExpressions;

public sealed record AddDecimalNullableRow
{
    public AddDecimalNullableRow(IEnumerable<DecimalNullableRow> values)
    {
        Values = values;
    }

    public IEnumerable<DecimalNullableRow> Values { get; }
}
