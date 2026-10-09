namespace PureQL.CSharp.Model.RowExpressions;

public sealed record CoalesceStringNullableRow
{
    public CoalesceStringNullableRow(IEnumerable<StringNullableRow> values)
    {
        Values = values;
    }

    public IEnumerable<StringNullableRow> Values { get; }
}
