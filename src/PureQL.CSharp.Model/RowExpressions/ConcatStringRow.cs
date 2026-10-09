namespace PureQL.CSharp.Model.RowExpressions;

public sealed record ConcatStringRow
{
    public ConcatStringRow(IEnumerable<StringRow> values)
    {
        Values = values;
    }

    public IEnumerable<StringRow> Values { get; }
}
