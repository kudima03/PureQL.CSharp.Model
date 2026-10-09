namespace PureQL.CSharp.Model.RowExpressions;

public sealed record AddIntegerNullableRow
{
    public AddIntegerNullableRow(IEnumerable<IntegerNullableRow> values)
    {
        Values = values;
    }

    public IEnumerable<IntegerNullableRow> Values { get; }
}
