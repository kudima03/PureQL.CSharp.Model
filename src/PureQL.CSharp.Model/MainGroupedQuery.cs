using PureQL.CSharp.Model.GroupExpressions;
using PureQL.CSharp.Model.GroupKeys;
using PureQL.CSharp.Model.RowExpressions;
using PureQL.CSharp.Model.SelectItems;

namespace PureQL.CSharp.Model;

public sealed record MainGroupedQuery
{
    public MainGroupedQuery(
        From from,
        IEnumerable<GroupKey> groupBy,
        IEnumerable<SelectItemGroup> select
    )
        : this(from, groupBy, select, null, null, null, null, null, null, false) { }

    public MainGroupedQuery(
        From from,
        IEnumerable<GroupKey> groupBy,
        IEnumerable<SelectItemGroup> select,
        IEnumerable<Subquery>? subqueries,
        IEnumerable<Join>? joins,
        BooleanRow? where,
        BooleanGroup? having,
        IEnumerable<OrderItemGroup>? orderBy,
        Pagination? pagination,
        bool distinct
    )
    {
        From = from;
        GroupBy = groupBy;
        Select = select;
        Subqueries = subqueries;
        Joins = joins;
        Where = where;
        Having = having;
        OrderBy = orderBy;
        Pagination = pagination;
        Distinct = distinct;
    }

    public From From { get; }

    public IEnumerable<GroupKey> GroupBy { get; }

    public IEnumerable<SelectItemGroup> Select { get; }

    public IEnumerable<Subquery>? Subqueries { get; }

    public IEnumerable<Join>? Joins { get; }

    public BooleanRow? Where { get; }

    public BooleanGroup? Having { get; }

    public IEnumerable<OrderItemGroup>? OrderBy { get; }

    public Pagination? Pagination { get; }

    public bool Distinct { get; }
}
