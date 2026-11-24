namespace PureQL.CSharp.Model;

/// <summary>PureQL <c>recursion</c>.</summary>
public sealed record Recursion
{
    public Recursion(Query seed, NextQuery next, RecursionMaxDepth maxDepth)
    {
        Seed = seed;
        Next = next;
        MaxDepth = maxDepth;
    }

    public Query Seed { get; }

    public NextQuery Next { get; }

    public RecursionMaxDepth MaxDepth { get; }
}
