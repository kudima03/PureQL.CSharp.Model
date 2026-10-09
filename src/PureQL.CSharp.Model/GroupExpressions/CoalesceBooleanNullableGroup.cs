namespace PureQL.CSharp.Model.GroupExpressions;

public sealed record CoalesceBooleanNullableGroup
{
    public CoalesceBooleanNullableGroup(IEnumerable<BooleanNullableGroup> values)
    {
        Values = values;
    }

    public IEnumerable<BooleanNullableGroup> Values { get; }
}
