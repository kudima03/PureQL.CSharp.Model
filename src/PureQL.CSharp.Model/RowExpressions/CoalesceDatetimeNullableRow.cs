namespace PureQL.CSharp.Model.RowExpressions;

public sealed record CoalesceDatetimeNullableRow
{
    public CoalesceDatetimeNullableRow(IEnumerable<DatetimeNullableRow> values)
    {
        Values = values;
    }

    public IEnumerable<DatetimeNullableRow> Values { get; }
}
