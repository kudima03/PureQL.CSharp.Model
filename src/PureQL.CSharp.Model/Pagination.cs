namespace PureQL.CSharp.Model;

public sealed record Pagination
{
    public Pagination(long skip, long take)
    {
        Skip = skip;
        Take = take;
    }

    public long Skip { get; }

    public long Take { get; }
}
