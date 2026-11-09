using PureQL.CSharp.Model.RowExpressions;

namespace PureQL.CSharp.Model;

public sealed record PlainQueryWithoutPaginationWithoutOrderBy
{
    public PlainQueryWithoutPaginationWithoutOrderBy(
        From from,
        IEnumerable<SelectItemProjection> select,
        IEnumerable<Join>? joins = null,
        BooleanRow? where = null,
        IEnumerable<string>? distinctBy = null
    )
    {
        From = from;
        Joins = joins;
        Where = where;
        DistinctBy = distinctBy;
        Select = select;
    }

    public From From { get; }

    public IEnumerable<Join>? Joins { get; }

    public BooleanRow? Where { get; }

    public IEnumerable<string>? DistinctBy { get; }

    public IEnumerable<SelectItemProjection> Select { get; }
}
