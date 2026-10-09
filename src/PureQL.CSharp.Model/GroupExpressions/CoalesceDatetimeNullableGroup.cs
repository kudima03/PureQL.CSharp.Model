namespace PureQL.CSharp.Model.GroupExpressions;

public sealed record CoalesceDatetimeNullableGroup
{
    public CoalesceDatetimeNullableGroup(IEnumerable<DatetimeNullableGroup> values)
    {
        Values = values;
    }

    public IEnumerable<DatetimeNullableGroup> Values { get; }
}
