namespace PureQL.CSharp.Model.GroupExpressions;

public sealed record ConcatStringGroup
{
    public ConcatStringGroup(IEnumerable<StringGroup> values)
    {
        Values = values;
    }

    public IEnumerable<StringGroup> Values { get; }
}
