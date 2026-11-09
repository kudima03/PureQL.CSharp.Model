namespace PureQL.CSharp.Model;

/// <summary>PureQL <c>subquery</c>.</summary>
public sealed record Subquery
{
    public Subquery(string name, Query query)
    {
        Name = name;
        Query = query;
    }

    public string Name { get; }

    public Query Query { get; }
}
