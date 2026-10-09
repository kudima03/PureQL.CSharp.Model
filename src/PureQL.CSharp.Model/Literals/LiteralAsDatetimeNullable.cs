using OneOf;

namespace PureQL.CSharp.Model.Literals;

public sealed class LiteralAsDatetimeNullable
    : OneOfBase<LiteralDatetime, LiteralDatetimeNullable>
{
    public LiteralAsDatetimeNullable(LiteralDatetime value)
        : this((OneOf<LiteralDatetime, LiteralDatetimeNullable>)value) { }

    public LiteralAsDatetimeNullable(LiteralDatetimeNullable value)
        : this((OneOf<LiteralDatetime, LiteralDatetimeNullable>)value) { }

    private LiteralAsDatetimeNullable(
        OneOf<LiteralDatetime, LiteralDatetimeNullable> input
    )
        : base(input) { }
}
