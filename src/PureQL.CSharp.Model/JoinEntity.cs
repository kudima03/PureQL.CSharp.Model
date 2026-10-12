using PureQL.CSharp.Model.RowExpressions;

namespace PureQL.CSharp.Model;

public sealed record JoinEntity
{
    public JoinEntity(JoinKind kind, string entity, BooleanRow on, string? alias = null)
    {
        Kind = kind;
        Entity = entity;
        On = on;
        Alias = alias;
    }

    public JoinKind Kind { get; }

    public string Entity { get; }

    public BooleanRow On { get; }

    public string? Alias { get; }
}
