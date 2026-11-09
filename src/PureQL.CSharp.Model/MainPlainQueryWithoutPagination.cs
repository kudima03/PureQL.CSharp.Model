using PureQL.CSharp.Model.RowExpressions;

namespace PureQL.CSharp.Model;

public sealed record MainPlainQueryWithoutPagination
{
    public MainPlainQueryWithoutPagination(
        From from,
        IEnumerable<SelectItemProjection> select,
        IEnumerable<Subquery>? subqueries = null,
        IEnumerable<Join>? joins = null,
        BooleanRow? where = null,
        IEnumerable<string>? distinctBy = null,
        IEnumerable<OrderItemProjection>? orderBy = null
    )
    {
        Subqueries = subqueries;
        From = from;
        Joins = joins;
        Where = where;
        DistinctBy = distinctBy;
        Select = select;
        OrderBy = orderBy;
    }

    public IEnumerable<Subquery>? Subqueries { get; }

    public From From { get; }

    public IEnumerable<Join>? Joins { get; }

    public BooleanRow? Where { get; }

    public IEnumerable<string>? DistinctBy { get; }

    public IEnumerable<SelectItemProjection> Select { get; }

    public IEnumerable<OrderItemProjection>? OrderBy { get; }
}
