using PureQL.CSharp.Model.RowExpressions;

namespace PureQL.CSharp.Model;

public sealed record JoinEntity
{
    public JoinEntity(JoinKind kind, string entity, BooleanRow on, string? alias = null)
    {
        Kind = kind;
        Entity = entity;
        Alias = alias;
        On = on;
    }

    public JoinKind Kind { get; }

    public string Entity { get; }

    public string? Alias { get; }

    public BooleanRow On { get; }
}
