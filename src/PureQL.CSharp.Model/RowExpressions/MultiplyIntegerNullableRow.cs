namespace PureQL.CSharp.Model.RowExpressions;

public sealed record MultiplyIntegerNullableRow
{
    public MultiplyIntegerNullableRow(IEnumerable<IntegerNullableRow> values)
    {
        Values = values;
    }

    public IEnumerable<IntegerNullableRow> Values { get; }
}
