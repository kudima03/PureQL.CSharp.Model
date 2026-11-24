using PureQL.CSharp.Model.GroupExpressions;
using PureQL.CSharp.Model.RowExpressions;

namespace PureQL.CSharp.Model;

/// <summary>PureQL <c>groupedNextQuery</c>.</summary>
public sealed record GroupedNextQuery
{
    public GroupedNextQuery(
        From from,
        IEnumerable<GroupKey> groupBy,
        IEnumerable<SelectItemGroup> select,
        IEnumerable<Join>? joins = null,
        BooleanRow? where = null,
        BooleanGroup? having = null
    )
    {
        From = from;
        Joins = joins;
        Where = where;
        GroupBy = groupBy;
        Having = having;
        Select = select;
    }

    public From From { get; }

    public IEnumerable<Join>? Joins { get; }

    public BooleanRow? Where { get; }

    public IEnumerable<GroupKey> GroupBy { get; }

    public BooleanGroup? Having { get; }

    public IEnumerable<SelectItemGroup> Select { get; }
}
