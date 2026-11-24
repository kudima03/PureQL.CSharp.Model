namespace PureQL.CSharp.Model;

public readonly union PureQLQuery(
    MainCombinedQueryUnionAll,
    MainCombinedQueryUnion,
    MainCombinedQueryIntersect,
    MainCombinedQueryExcept,
    MainGroupedQueryWithoutPagination,
    MainGroupedQueryWithPagination,
    MainTotalQuery,
    MainPlainQueryWithoutPagination,
    MainPlainQueryWithPagination
);
