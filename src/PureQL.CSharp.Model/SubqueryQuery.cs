namespace PureQL.CSharp.Model;

public sealed record SubqueryQuery
{
    public SubqueryQuery(string name, Query query)
    {
        Name = name;
        Query = query;
    }

    public string Name { get; }

    public Query Query { get; }
}
