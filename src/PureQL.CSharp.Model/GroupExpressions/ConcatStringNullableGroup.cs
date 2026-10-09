namespace PureQL.CSharp.Model.GroupExpressions;

public sealed record ConcatStringNullableGroup
{
    public ConcatStringNullableGroup(IEnumerable<StringNullableGroup> values)
    {
        Values = values;
    }

    public IEnumerable<StringNullableGroup> Values { get; }
}
