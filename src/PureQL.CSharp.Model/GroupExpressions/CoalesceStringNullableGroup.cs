namespace PureQL.CSharp.Model.GroupExpressions;

public sealed record CoalesceStringNullableGroup
{
    public CoalesceStringNullableGroup(IEnumerable<StringNullableGroup> values)
    {
        Values = values;
    }

    public IEnumerable<StringNullableGroup> Values { get; }
}
