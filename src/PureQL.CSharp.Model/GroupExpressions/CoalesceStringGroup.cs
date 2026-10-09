namespace PureQL.CSharp.Model.GroupExpressions;

public sealed record CoalesceStringGroup
{
    public CoalesceStringGroup(IEnumerable<StringNullableGroup> values)
    {
        Values = values;
    }

    public IEnumerable<StringNullableGroup> Values { get; }
}
