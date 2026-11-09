using PureQL.CSharp.Model.GroupExpressions;
using PureQL.CSharp.Model.RowExpressions;

namespace PureQL.CSharp.Model;

public sealed record GroupedQueryWithoutPaginationWithoutOrderBy
{
    public GroupedQueryWithoutPaginationWithoutOrderBy(
        From from,
        IEnumerable<GroupKey> groupBy,
        IEnumerable<SelectItemGroup> select,
        IEnumerable<Join>? joins = null,
        BooleanRow? where = null,
        IEnumerable<string>? distinctBy = null,
        BooleanGroup? having = null
    )
    {
        From = from;
        Joins = joins;
        Where = where;
        DistinctBy = distinctBy;
        GroupBy = groupBy;
        Having = having;
        Select = select;
    }

    public From From { get; }

    public IEnumerable<Join>? Joins { get; }

    public BooleanRow? Where { get; }

    public IEnumerable<string>? DistinctBy { get; }

    public IEnumerable<GroupKey> GroupBy { get; }

    public BooleanGroup? Having { get; }

    public IEnumerable<SelectItemGroup> Select { get; }
}
