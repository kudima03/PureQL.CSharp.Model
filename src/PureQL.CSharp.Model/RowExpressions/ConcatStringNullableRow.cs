namespace PureQL.CSharp.Model.RowExpressions;

public sealed record ConcatStringNullableRow
{
    public ConcatStringNullableRow(IEnumerable<StringNullableRow> values)
    {
        Values = values;
    }

    public IEnumerable<StringNullableRow> Values { get; }
}
