using OneOf;

namespace PureQL.CSharp.Model;

public sealed class Join : OneOfBase<JoinEntity, JoinSubquery>
{
    public Join(JoinEntity value)
        : this((OneOf<JoinEntity, JoinSubquery>)value) { }

    public Join(JoinSubquery value)
        : this((OneOf<JoinEntity, JoinSubquery>)value) { }

    private Join(OneOf<JoinEntity, JoinSubquery> input)
        : base(input) { }
}
