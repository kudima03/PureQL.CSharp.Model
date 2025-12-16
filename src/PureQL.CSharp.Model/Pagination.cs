namespace PureQL.CSharp.Model;

public sealed record Pagination
{
    public long Skip { get; }

    public long Take { get; }
}
