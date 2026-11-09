using PureQL.CSharp.Model.GroupExpressions;
using PureQL.CSharp.Model.RowExpressions;

namespace PureQL.CSharp.Model;

public sealed record MainGroupedQueryWithPagination
{
    public MainGroupedQueryWithPagination(
        From from,
        Pagination pagination,
        IEnumerable<GroupKey> groupBy,
        IEnumerable<SelectItemGroup> select,
        IEnumerable<OrderItemGroup> orderBy,
        IEnumerable<Subquery>? subqueries = null,
        IEnumerable<Join>? joins = null,
        BooleanRow? where = null,
        IEnumerable<string>? distinctBy = null,
        BooleanGroup? having = null
    )
    {
        Subqueries = subqueries;
        From = from;
        Joins = joins;
        Where = where;
        DistinctBy = distinctBy;
        Pagination = pagination;
        GroupBy = groupBy;
        Having = having;
        Select = select;
        OrderBy = orderBy;
    }

    public IEnumerable<Subquery>? Subqueries { get; }

    public From From { get; }

    public IEnumerable<Join>? Joins { get; }

    public BooleanRow? Where { get; }

    public IEnumerable<string>? DistinctBy { get; }

    public Pagination Pagination { get; }

    public IEnumerable<GroupKey> GroupBy { get; }

    public BooleanGroup? Having { get; }

    public IEnumerable<SelectItemGroup> Select { get; }

    public IEnumerable<OrderItemGroup> OrderBy { get; }
}
