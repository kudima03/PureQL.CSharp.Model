namespace PureQL.CSharp.Model.RowExpressions;

public sealed record SubtractDecimalRow
{
    public SubtractDecimalRow(IEnumerable<DecimalRow> values)
    {
        Values = values;
    }

    public IEnumerable<DecimalRow> Values { get; }
}
