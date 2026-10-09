using PureQL.CSharp.Model.RowExpressions;

namespace PureQL.CSharp.Model;

public sealed record JoinEntity
{
    public JoinEntity(JoinType type, string entity, BooleanRow on, string? alias = null)
    {
        Type = type;
        Entity = entity;
        On = on;
        Alias = alias;
    }

    public JoinType Type { get; }

    public string Entity { get; }

    public BooleanRow On { get; }

    public string? Alias { get; }
}
