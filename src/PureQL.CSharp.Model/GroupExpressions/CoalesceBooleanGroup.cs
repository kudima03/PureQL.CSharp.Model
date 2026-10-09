namespace PureQL.CSharp.Model.GroupExpressions;

public sealed record CoalesceBooleanGroup
{
    public CoalesceBooleanGroup(IEnumerable<BooleanNullableGroup> values)
    {
        Values = values;
    }

    public IEnumerable<BooleanNullableGroup> Values { get; }
}
