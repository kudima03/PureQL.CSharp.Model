using PureQL.CSharp.Model.RowExpressions;

namespace PureQL.CSharp.Model;

public sealed record PlainQueryWithoutPaginationWithOrderBy
{
    public PlainQueryWithoutPaginationWithOrderBy(
        From from,
        IEnumerable<string> distinctBy,
        IEnumerable<SelectItemProjection> select,
        IEnumerable<OrderItemProjection> orderBy,
        IEnumerable<Join>? joins = null,
        BooleanRow? where = null
    )
    {
        From = from;
        Joins = joins;
        Where = where;
        DistinctBy = distinctBy;
        Select = select;
        OrderBy = orderBy;
    }

    public From From { get; }

    public IEnumerable<Join>? Joins { get; }

    public BooleanRow? Where { get; }

    public IEnumerable<string> DistinctBy { get; }

    public IEnumerable<SelectItemProjection> Select { get; }

    public IEnumerable<OrderItemProjection> OrderBy { get; }
}
