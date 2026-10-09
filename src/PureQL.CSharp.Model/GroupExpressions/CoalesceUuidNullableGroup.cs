namespace PureQL.CSharp.Model.GroupExpressions;

public sealed record CoalesceUuidNullableGroup
{
    public CoalesceUuidNullableGroup(IEnumerable<UuidNullableGroup> values)
    {
        Values = values;
    }

    public IEnumerable<UuidNullableGroup> Values { get; }
}
