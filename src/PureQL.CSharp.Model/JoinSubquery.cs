using PureQL.CSharp.Model.RowExpressions;

namespace PureQL.CSharp.Model;

public sealed record JoinSubquery
{
    public JoinSubquery(
        JoinKind kind,
        string subquery,
        BooleanRow on,
        string? alias = null
    )
    {
        Kind = kind;
        Subquery = subquery;
        On = on;
        Alias = alias;
    }

    public JoinKind Kind { get; }

    public string Subquery { get; }

    public BooleanRow On { get; }

    public string? Alias { get; }
}
