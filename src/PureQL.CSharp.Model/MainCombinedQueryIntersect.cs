namespace PureQL.CSharp.Model;

public sealed record MainCombinedQueryIntersect
{
    public MainCombinedQueryIntersect(
        IEnumerable<Query> intersect,
        IEnumerable<Subquery>? subqueries = null
    )
    {
        Subqueries = subqueries;
        Intersect = intersect;
    }

    public IEnumerable<Subquery>? Subqueries { get; }

    public IEnumerable<Query> Intersect { get; }
}
