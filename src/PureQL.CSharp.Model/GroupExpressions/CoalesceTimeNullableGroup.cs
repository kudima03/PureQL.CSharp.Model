namespace PureQL.CSharp.Model.GroupExpressions;

public sealed record CoalesceTimeNullableGroup
{
    public CoalesceTimeNullableGroup(IEnumerable<TimeNullableGroup> values)
    {
        Values = values;
    }

    public IEnumerable<TimeNullableGroup> Values { get; }
}
