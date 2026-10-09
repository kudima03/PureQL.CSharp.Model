namespace PureQL.CSharp.Model.RowExpressions;

public sealed record SubtractIntegerNullableRow
{
    public SubtractIntegerNullableRow(IEnumerable<IntegerNullableRow> values)
    {
        Values = values;
    }

    public IEnumerable<IntegerNullableRow> Values { get; }
}
