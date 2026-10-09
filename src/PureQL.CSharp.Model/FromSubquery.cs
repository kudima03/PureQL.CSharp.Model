namespace PureQL.CSharp.Model;

public sealed record FromSubquery
{
    public FromSubquery(string subquery, string? alias = null)
    {
        Subquery = subquery;
        Alias = alias;
    }

    public string Subquery { get; }

    public string? Alias { get; }
}
