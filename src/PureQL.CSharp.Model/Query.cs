namespace PureQL.CSharp.Model;

/// <summary>PureQL <c>query</c>.</summary>
public readonly union Query(
    GroupedQueryWithoutPaginationWithoutOrderBy,
    GroupedQueryWithoutPaginationWithOrderBy,
    GroupedQueryWithPagination,
    TotalQuery,
    PlainQueryWithoutPaginationWithoutOrderBy,
    PlainQueryWithoutPaginationWithOrderBy,
    PlainQueryWithPagination
);
