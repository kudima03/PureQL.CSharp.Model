namespace PureQL.CSharp.Model.RowExpressions;

public sealed record MultiplyDecimalRow
{
    public MultiplyDecimalRow(IEnumerable<DecimalRow> values)
    {
        Values = values;
    }

    public IEnumerable<DecimalRow> Values { get; }
}
