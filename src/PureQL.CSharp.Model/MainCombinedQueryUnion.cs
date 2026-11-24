namespace PureQL.CSharp.Model;

public sealed record MainCombinedQueryUnion
{
    public MainCombinedQueryUnion(
        IEnumerable<Query> union,
        IEnumerable<Subquery>? subqueries = null
    )
    {
        Subqueries = subqueries;
        Union = union;
    }

    public IEnumerable<Subquery>? Subqueries { get; }

    public IEnumerable<Query> Union { get; }
}
