namespace PureQL.CSharp.Model.RowExpressions;

public sealed record CoalesceBooleanNullableRow
{
    public CoalesceBooleanNullableRow(IEnumerable<BooleanNullableRow> values)
    {
        Values = values;
    }

    public IEnumerable<BooleanNullableRow> Values { get; }
}
