namespace PureQL.CSharp.Model.RowExpressions;

public sealed record CoalesceIntegerNullableRow
{
    public CoalesceIntegerNullableRow(IEnumerable<IntegerNullableRow> values)
    {
        Values = values;
    }

    public IEnumerable<IntegerNullableRow> Values { get; }
}
