namespace PureQL.CSharp.Model.RowExpressions;

public sealed record AddIntegerRow
{
    public AddIntegerRow(IEnumerable<IntegerRow> values)
    {
        Values = values;
    }

    public IEnumerable<IntegerRow> Values { get; }
}
