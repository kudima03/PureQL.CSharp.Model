namespace PureQL.CSharp.Model;

public sealed record SubqueryRecursive
{
    public SubqueryRecursive(string name, Recursion recursive)
    {
        Name = name;
        Recursive = recursive;
    }

    public string Name { get; }

    public Recursion Recursive { get; }
}
