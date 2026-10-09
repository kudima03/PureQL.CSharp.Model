namespace PureQL.CSharp.Model.GroupExpressions;

public sealed record CoalesceDatetimeGroup
{
    public CoalesceDatetimeGroup(IEnumerable<DatetimeNullableGroup> values)
    {
        Values = values;
    }

    public IEnumerable<DatetimeNullableGroup> Values { get; }
}
