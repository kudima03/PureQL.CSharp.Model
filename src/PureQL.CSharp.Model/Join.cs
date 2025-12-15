using PureQL.CSharp.Model.Returnings;

namespace PureQL.CSharp.Model;

public sealed record Join
{
    public Join(JoinType type, string entity, BooleanReturning on)
    {
        Type = type;
        Entity = entity;
        On = on;
    }

    public JoinType Type { get; }

    public string Entity { get; }

    public BooleanReturning On { get; }
}
