using PureQL.CSharp.Model.RowExpressions;

namespace PureQL.CSharp.Model;

/// <summary>PureQL <c>plainNextQuery</c>.</summary>
public sealed record PlainNextQuery
{
    public PlainNextQuery(
        From from,
        IEnumerable<SelectItemRow> select,
        IEnumerable<Join>? joins = null,
        BooleanRow? where = null
    )
    {
        From = from;
        Joins = joins;
        Where = where;
        Select = select;
    }

    public From From { get; }

    public IEnumerable<Join>? Joins { get; }

    public BooleanRow? Where { get; }

    public IEnumerable<SelectItemRow> Select { get; }
}
