namespace PureQL.CSharp.Model.RowExpressions;

public sealed record CoalesceBooleanRow
{
    public CoalesceBooleanRow(IEnumerable<BooleanNullableRow> values)
    {
        Values = values;
    }

    public IEnumerable<BooleanNullableRow> Values { get; }
}
