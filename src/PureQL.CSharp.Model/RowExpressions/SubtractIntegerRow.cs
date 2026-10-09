namespace PureQL.CSharp.Model.RowExpressions;

public sealed record SubtractIntegerRow
{
    public SubtractIntegerRow(IEnumerable<IntegerRow> values)
    {
        Values = values;
    }

    public IEnumerable<IntegerRow> Values { get; }
}
