using OneOf;

namespace PureQL.CSharp.Model;

public sealed class From : OneOfBase<FromEntity, FromSubquery>
{
    public From(FromEntity value)
        : this((OneOf<FromEntity, FromSubquery>)value) { }

    public From(FromSubquery value)
        : this((OneOf<FromEntity, FromSubquery>)value) { }

    private From(OneOf<FromEntity, FromSubquery> input)
        : base(input) { }
}
