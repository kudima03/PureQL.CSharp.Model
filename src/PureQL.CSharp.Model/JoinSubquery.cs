using PureQL.CSharp.Model.RowExpressions;

namespace PureQL.CSharp.Model;

public sealed record JoinSubquery
{
    public JoinSubquery(
        JoinType type,
        string subquery,
        BooleanRow on,
        string? alias = null
    )
    {
        Type = type;
        Subquery = subquery;
        On = on;
        Alias = alias;
    }

    public JoinType Type { get; }

    public string Subquery { get; }

    public BooleanRow On { get; }

    public string? Alias { get; }
}
