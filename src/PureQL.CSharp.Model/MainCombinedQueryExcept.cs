namespace PureQL.CSharp.Model;

public sealed record MainCombinedQueryExcept
{
    public MainCombinedQueryExcept(
        IEnumerable<Query> except,
        IEnumerable<Subquery>? subqueries = null
    )
    {
        Subqueries = subqueries;
        Except = except;
    }

    public IEnumerable<Subquery>? Subqueries { get; }

    public IEnumerable<Query> Except { get; }
}
