namespace PureQL.CSharp.Model.RowExpressions;

public sealed record MultiplyDecimalNullableRow
{
    public MultiplyDecimalNullableRow(IEnumerable<DecimalNullableRow> values)
    {
        Values = values;
    }

    public IEnumerable<DecimalNullableRow> Values { get; }
}
