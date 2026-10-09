namespace PureQL.CSharp.Model.GroupExpressions;

public sealed record CoalesceUuidGroup
{
    public CoalesceUuidGroup(IEnumerable<UuidNullableGroup> values)
    {
        Values = values;
    }

    public IEnumerable<UuidNullableGroup> Values { get; }
}
