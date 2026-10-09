namespace PureQL.CSharp.Model.RowExpressions;

public sealed record CoalesceIntegerRow
{
    public CoalesceIntegerRow(IEnumerable<IntegerNullableRow> values)
    {
        Values = values;
    }

    public IEnumerable<IntegerNullableRow> Values { get; }
}
