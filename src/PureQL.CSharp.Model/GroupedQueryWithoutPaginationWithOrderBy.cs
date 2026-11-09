using PureQL.CSharp.Model.GroupExpressions;
using PureQL.CSharp.Model.RowExpressions;

namespace PureQL.CSharp.Model;

public sealed record GroupedQueryWithoutPaginationWithOrderBy
{
    public GroupedQueryWithoutPaginationWithOrderBy(
        From from,
        IEnumerable<string> distinctBy,
        IEnumerable<GroupKey> groupBy,
        IEnumerable<SelectItemGroup> select,
        IEnumerable<OrderItemGroup> orderBy,
        IEnumerable<Join>? joins = null,
        BooleanRow? where = null,
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
        OrderBy = orderBy;
    }

    public From From { get; }

    public IEnumerable<Join>? Joins { get; }

    public BooleanRow? Where { get; }

    public IEnumerable<string> DistinctBy { get; }

    public IEnumerable<GroupKey> GroupBy { get; }

    public BooleanGroup? Having { get; }

    public IEnumerable<SelectItemGroup> Select { get; }

    public IEnumerable<OrderItemGroup> OrderBy { get; }
}
