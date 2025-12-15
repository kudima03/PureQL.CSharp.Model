using PureQL.CSharp.Model.Fields;
using PureQL.CSharp.Model.Returnings;

namespace PureQL.CSharp.Model;

public sealed record Query
{
    public Query(IFromExpression from, SelectExpression select)
        : this(from, select, null, null, null, null, null, null) { }

    public Query(
        IFromExpression from,
        SelectExpression select,
        BooleanReturning? where,
        IEnumerable<Join>? join,
        IEnumerable<Field>? groupBy,
        BooleanReturning? having,
        IEnumerable<Field>? orderBy,
        IPagination? pagination
    )
    {
        From = from;
        Select = select;
        Where = where;
        Join = join;
        GroupBy = groupBy;
        Having = having;
        OrderBy = orderBy;
        Pagination = pagination;
    }

    public IFromExpression From { get; }

    public SelectExpression Select { get; }

    public BooleanReturning? Where { get; }

    public IEnumerable<Join>? Join { get; }

    public IEnumerable<Field>? GroupBy { get; }

    public BooleanReturning? Having { get; }

    public IEnumerable<Field>? OrderBy { get; }

    public IPagination? Pagination { get; }
}
