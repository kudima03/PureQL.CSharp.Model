namespace PureQL.CSharp.Model.RowExpressions;

public sealed record CoalesceDatetimeRow
{
    public CoalesceDatetimeRow(IEnumerable<DatetimeNullableRow> values)
    {
        Values = values;
    }

    public IEnumerable<DatetimeNullableRow> Values { get; }
}
