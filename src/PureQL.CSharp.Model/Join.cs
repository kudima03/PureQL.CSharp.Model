using OneOf;
using PureQL.CSharp.Model.ArrayReturnings;
using PureQL.CSharp.Model.Returnings;

namespace PureQL.CSharp.Model;

public sealed record Join
{
    public Join(JoinType type, string entity, BooleanReturning on)
        : this(type, entity, (OneOf<BooleanReturning, BooleanArrayReturning>)on) { }

    public Join(JoinType type, string entity, BooleanArrayReturning on)
        : this(type, entity, (OneOf<BooleanReturning, BooleanArrayReturning>)on) { }

    private Join(
        JoinType type,
        string entity,
        OneOf<BooleanReturning, BooleanArrayReturning> on
    )
    {
        Type = type;
        Entity = entity;
        On = on;
    }

    public JoinType Type { get; }

    public string Entity { get; }

    public OneOf<BooleanReturning, BooleanArrayReturning> On { get; }
}
