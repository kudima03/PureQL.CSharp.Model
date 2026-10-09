namespace PureQL.CSharp.Model.RowExpressions;

public sealed record CoalesceDateNullableRow
{
    public CoalesceDateNullableRow(IEnumerable<DateNullableRow> values)
    {
        Values = values;
    }

    public IEnumerable<DateNullableRow> Values { get; }
}
