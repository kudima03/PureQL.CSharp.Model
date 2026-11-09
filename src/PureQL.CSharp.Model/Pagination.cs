namespace PureQL.CSharp.Model;

/// <summary>PureQL <c>pagination</c>.</summary>
public sealed record Pagination
{
    public Pagination(PaginationSkip skip, PaginationTake take)
    {
        Skip = skip;
        Take = take;
    }

    public PaginationSkip Skip { get; }

    public PaginationTake Take { get; }
}
