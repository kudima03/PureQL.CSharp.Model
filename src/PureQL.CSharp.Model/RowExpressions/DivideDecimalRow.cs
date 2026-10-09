namespace PureQL.CSharp.Model.RowExpressions;

public sealed record DivideDecimalRow
{
    public DivideDecimalRow(IEnumerable<DecimalRow> values)
    {
        Values = values;
    }

    public IEnumerable<DecimalRow> Values { get; }
}
