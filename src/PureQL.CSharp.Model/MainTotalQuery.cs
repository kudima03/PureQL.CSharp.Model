using PureQL.CSharp.Model.RowExpressions;
using PureQL.CSharp.Model.SelectItems;

namespace PureQL.CSharp.Model;

public sealed record MainTotalQuery
{
    public MainTotalQuery(From from, IEnumerable<SelectItemTotal> aggregate)
        : this(from, aggregate, null, null, null) { }

    public MainTotalQuery(
        From from,
        IEnumerable<SelectItemTotal> aggregate,
        IEnumerable<Subquery>? subqueries,
        IEnumerable<Join>? joins,
        BooleanRow? where
    )
    {
        From = from;
        Aggregate = aggregate;
        Subqueries = subqueries;
        Joins = joins;
        Where = where;
    }

    public From From { get; }

    public IEnumerable<SelectItemTotal> Aggregate { get; }

    public IEnumerable<Subquery>? Subqueries { get; }

    public IEnumerable<Join>? Joins { get; }

    public BooleanRow? Where { get; }
}
