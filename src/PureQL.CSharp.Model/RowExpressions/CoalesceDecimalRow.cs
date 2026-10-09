namespace PureQL.CSharp.Model.RowExpressions;

public sealed record CoalesceDecimalRow
{
    public CoalesceDecimalRow(IEnumerable<DecimalNullableRow> values)
    {
        Values = values;
    }

    public IEnumerable<DecimalNullableRow> Values { get; }
}
