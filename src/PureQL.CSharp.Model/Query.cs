using OneOf;
using PureQL.CSharp.Model.ArrayReturnings;
using PureQL.CSharp.Model.Fields;
using PureQL.CSharp.Model.Returnings;

namespace PureQL.CSharp.Model;

public sealed record Query
{
    public Query(FromExpression from, IEnumerable<SelectExpression> select)
        : this(from, select, null, null, null, null, null, null, false) { }

    public Query(
        FromExpression from,
        IEnumerable<SelectExpression> selectExpressions,
        OneOf<BooleanReturning, BooleanArrayReturning>? where,
        IEnumerable<Join>? join,
        IEnumerable<Field>? groupBy,
        BooleanReturning? having,
        IEnumerable<OrderByItem>? orderBy,
        Pagination? pagination,
        bool distinct = false
    )
    {
        From = from;
        SelectExpressions = selectExpressions;
        Where = where;
        Join = join;
        GroupBy = groupBy;
        Having = having;
        OrderBy = orderBy;
        Pagination = pagination;
        Distinct = distinct;
    }

    public FromExpression From { get; }

    public IEnumerable<SelectExpression> SelectExpressions { get; }

    public OneOf<BooleanReturning, BooleanArrayReturning>? Where { get; }

    public IEnumerable<Join>? Join { get; }

    public IEnumerable<Field>? GroupBy { get; }

    public BooleanReturning? Having { get; }

    public IEnumerable<OrderByItem>? OrderBy { get; }

    public Pagination? Pagination { get; }

    public bool Distinct { get; }
}
