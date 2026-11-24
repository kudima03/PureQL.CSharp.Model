namespace PureQL.CSharp.Model;

public sealed record MainCombinedQueryUnionAll
{
    public MainCombinedQueryUnionAll(
        IEnumerable<Query> unionAll,
        IEnumerable<Subquery>? subqueries = null
    )
    {
        Subqueries = subqueries;
        UnionAll = unionAll;
    }

    public IEnumerable<Subquery>? Subqueries { get; }

    public IEnumerable<Query> UnionAll { get; }
}
