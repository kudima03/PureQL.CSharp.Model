using PureQL.CSharp.Model.RowExpressions;
using PureQL.CSharp.Model.SelectItems;

namespace PureQL.CSharp.Model;

public sealed record PlainQuery
{
    public PlainQuery(From from, IEnumerable<SelectItemProjection> select)
        : this(from, select, null, null, null, null, false) { }

    public PlainQuery(
        From from,
        IEnumerable<SelectItemProjection> select,
        IEnumerable<Join>? joins,
        BooleanRow? where,
        IEnumerable<OrderItemProjection>? orderBy,
        Pagination? pagination,
        bool distinct
    )
    {
        From = from;
        Select = select;
        Joins = joins;
        Where = where;
        OrderBy = orderBy;
        Pagination = pagination;
        Distinct = distinct;
    }

    public From From { get; }

    public IEnumerable<SelectItemProjection> Select { get; }

    public IEnumerable<Join>? Joins { get; }

    public BooleanRow? Where { get; }

    public IEnumerable<OrderItemProjection>? OrderBy { get; }

    public Pagination? Pagination { get; }

    public bool Distinct { get; }
}
