namespace PureQL.CSharp.Model;

public sealed record CombinedQueryUnionAll
{
    public CombinedQueryUnionAll(IEnumerable<Query> unionAll)
    {
        UnionAll = unionAll;
    }

    public IEnumerable<Query> UnionAll { get; }
}
