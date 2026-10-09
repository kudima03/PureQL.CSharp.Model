namespace PureQL.CSharp.Model.RowExpressions;

public sealed record CoalesceDecimalNullableRow
{
    public CoalesceDecimalNullableRow(IEnumerable<DecimalNullableRow> values)
    {
        Values = values;
    }

    public IEnumerable<DecimalNullableRow> Values { get; }
}
