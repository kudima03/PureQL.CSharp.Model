using PureQL.CSharp.Model.RowExpressions;

namespace PureQL.CSharp.Model;

/// <summary>PureQL <c>mainTotalQuery</c>.</summary>
public sealed record MainTotalQuery
{
    public MainTotalQuery(
        From from,
        IEnumerable<SelectItemTotal> aggregate,
        IEnumerable<Subquery>? subqueries = null,
        IEnumerable<Join>? joins = null,
        BooleanRow? where = null
    )
    {
        Subqueries = subqueries;
        From = from;
        Joins = joins;
        Where = where;
        Aggregate = aggregate;
    }

    public IEnumerable<Subquery>? Subqueries { get; }

    public From From { get; }

    public IEnumerable<Join>? Joins { get; }

    public BooleanRow? Where { get; }

    public IEnumerable<SelectItemTotal> Aggregate { get; }
}
