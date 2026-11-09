using PureQL.CSharp.Model.RowExpressions;

namespace PureQL.CSharp.Model;

/// <summary>PureQL <c>totalQuery</c>.</summary>
public sealed record TotalQuery
{
    public TotalQuery(
        From from,
        IEnumerable<SelectItemTotal> aggregate,
        IEnumerable<Join>? joins = null,
        BooleanRow? where = null
    )
    {
        From = from;
        Joins = joins;
        Where = where;
        Aggregate = aggregate;
    }

    public From From { get; }

    public IEnumerable<Join>? Joins { get; }

    public BooleanRow? Where { get; }

    public IEnumerable<SelectItemTotal> Aggregate { get; }
}
