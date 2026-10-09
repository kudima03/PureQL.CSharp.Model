namespace PureQL.CSharp.Model.GroupExpressions;

public sealed record CoalesceDateNullableGroup
{
    public CoalesceDateNullableGroup(IEnumerable<DateNullableGroup> values)
    {
        Values = values;
    }

    public IEnumerable<DateNullableGroup> Values { get; }
}
