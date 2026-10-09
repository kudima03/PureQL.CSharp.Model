namespace PureQL.CSharp.Model.GroupExpressions;

public sealed record CoalesceTimeGroup
{
    public CoalesceTimeGroup(IEnumerable<TimeNullableGroup> values)
    {
        Values = values;
    }

    public IEnumerable<TimeNullableGroup> Values { get; }
}
