namespace PureQL.CSharp.Model.GroupExpressions;

public sealed record CoalesceDateGroup
{
    public CoalesceDateGroup(IEnumerable<DateNullableGroup> values)
    {
        Values = values;
    }

    public IEnumerable<DateNullableGroup> Values { get; }
}
