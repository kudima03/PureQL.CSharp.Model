using OneOf;

namespace PureQL.CSharp.Model.Literals;

public sealed class LiteralAsUuidNullable : OneOfBase<LiteralUuid, LiteralUuidNullable>
{
    public LiteralAsUuidNullable(LiteralUuid value)
        : this((OneOf<LiteralUuid, LiteralUuidNullable>)value) { }

    public LiteralAsUuidNullable(LiteralUuidNullable value)
        : this((OneOf<LiteralUuid, LiteralUuidNullable>)value) { }

    private LiteralAsUuidNullable(OneOf<LiteralUuid, LiteralUuidNullable> input)
        : base(input) { }
}
