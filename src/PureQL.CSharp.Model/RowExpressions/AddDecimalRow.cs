namespace PureQL.CSharp.Model.RowExpressions;

public sealed record AddDecimalRow
{
    public AddDecimalRow(IEnumerable<DecimalRow> values)
    {
        Values = values;
    }

    public IEnumerable<DecimalRow> Values { get; }
}
