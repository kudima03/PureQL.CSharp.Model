namespace PureQL.CSharp.Model.RowExpressions;

public sealed record DivideDecimalNullableRow
{
    public DivideDecimalNullableRow(IEnumerable<DecimalNullableRow> values)
    {
        Values = values;
    }

    public IEnumerable<DecimalNullableRow> Values { get; }
}
