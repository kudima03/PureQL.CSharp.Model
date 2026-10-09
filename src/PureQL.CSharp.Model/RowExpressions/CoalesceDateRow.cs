namespace PureQL.CSharp.Model.RowExpressions;

public sealed record CoalesceDateRow
{
    public CoalesceDateRow(IEnumerable<DateNullableRow> values)
    {
        Values = values;
    }

    public IEnumerable<DateNullableRow> Values { get; }
}
