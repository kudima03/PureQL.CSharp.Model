namespace PureQL.CSharp.Model;

public sealed record CombinedQueryUnion
{
    public CombinedQueryUnion(IEnumerable<Query> union)
    {
        Union = union;
    }

    public IEnumerable<Query> Union { get; }
}
