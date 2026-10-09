namespace PureQL.CSharp.Model.RowExpressions;

public sealed record MultiplyIntegerRow
{
    public MultiplyIntegerRow(IEnumerable<IntegerRow> values)
    {
        Values = values;
    }

    public IEnumerable<IntegerRow> Values { get; }
}
