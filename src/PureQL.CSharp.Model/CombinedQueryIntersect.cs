namespace PureQL.CSharp.Model;

public sealed record CombinedQueryIntersect
{
    public CombinedQueryIntersect(IEnumerable<Query> intersect)
    {
        Intersect = intersect;
    }

    public IEnumerable<Query> Intersect { get; }
}
