namespace PureQL.CSharp.Model;

public sealed record CombinedQueryExcept
{
    public CombinedQueryExcept(IEnumerable<Query> except)
    {
        Except = except;
    }

    public IEnumerable<Query> Except { get; }
}
