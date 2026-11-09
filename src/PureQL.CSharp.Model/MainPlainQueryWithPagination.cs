using PureQL.CSharp.Model.RowExpressions;

namespace PureQL.CSharp.Model;

public sealed record MainPlainQueryWithPagination
{
    public MainPlainQueryWithPagination(
        From from,
        Pagination pagination,
        IEnumerable<SelectItemProjection> select,
        IEnumerable<OrderItemProjection> orderBy,
        IEnumerable<Subquery>? subqueries = null,
        IEnumerable<Join>? joins = null,
        BooleanRow? where = null,
        IEnumerable<string>? distinctBy = null
    )
    {
        Subqueries = subqueries;
        From = from;
        Joins = joins;
        Where = where;
        DistinctBy = distinctBy;
        Pagination = pagination;
        Select = select;
        OrderBy = orderBy;
    }

    public IEnumerable<Subquery>? Subqueries { get; }

    public From From { get; }

    public IEnumerable<Join>? Joins { get; }

    public BooleanRow? Where { get; }

    public IEnumerable<string>? DistinctBy { get; }

    public Pagination Pagination { get; }

    public IEnumerable<SelectItemProjection> Select { get; }

    public IEnumerable<OrderItemProjection> OrderBy { get; }
}
