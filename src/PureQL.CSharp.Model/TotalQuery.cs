using PureQL.CSharp.Model.RowExpressions;
using PureQL.CSharp.Model.SelectItems;

namespace PureQL.CSharp.Model;

public sealed record TotalQuery
{
    public TotalQuery(From from, IEnumerable<SelectItemTotal> aggregate)
        : this(from, aggregate, null, null) { }

    public TotalQuery(
        From from,
        IEnumerable<SelectItemTotal> aggregate,
        IEnumerable<Join>? joins,
        BooleanRow? where
    )
    {
        From = from;
        Aggregate = aggregate;
        Joins = joins;
        Where = where;
    }

    public From From { get; }

    public IEnumerable<SelectItemTotal> Aggregate { get; }

    public IEnumerable<Join>? Joins { get; }

    public BooleanRow? Where { get; }
}
