namespace PureQL.CSharp.Model;

public readonly union PureQLQuery(
    MainGroupedQueryWithoutPagination,
    MainGroupedQueryWithPagination,
    MainTotalQuery,
    MainPlainQueryWithoutPagination,
    MainPlainQueryWithPagination
);
