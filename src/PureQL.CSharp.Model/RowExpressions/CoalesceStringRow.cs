namespace PureQL.CSharp.Model.RowExpressions;

public sealed record CoalesceStringRow
{
    public CoalesceStringRow(IEnumerable<StringNullableRow> values)
    {
        Values = values;
    }

    public IEnumerable<StringNullableRow> Values { get; }
}
