namespace PureQL.CSharp.Model;

/// <summary>PureQL <c>query</c>.</summary>
public readonly union Query(
    CombinedQueryUnionAll,
    CombinedQueryUnion,
    CombinedQueryIntersect,
    CombinedQueryExcept,
    GroupedQueryWithoutPaginationWithoutOrderBy,
    GroupedQueryWithoutPaginationWithOrderBy,
    GroupedQueryWithPagination,
    TotalQuery,
    PlainQueryWithoutPaginationWithoutOrderBy,
    PlainQueryWithoutPaginationWithOrderBy,
    PlainQueryWithPagination
);
