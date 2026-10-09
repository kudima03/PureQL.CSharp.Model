using OneOf;

namespace PureQL.CSharp.Model.Literals;

public sealed class LiteralAsTimeNullable : OneOfBase<LiteralTime, LiteralTimeNullable>
{
    public LiteralAsTimeNullable(LiteralTime value)
        : this((OneOf<LiteralTime, LiteralTimeNullable>)value) { }

    public LiteralAsTimeNullable(LiteralTimeNullable value)
        : this((OneOf<LiteralTime, LiteralTimeNullable>)value) { }

    private LiteralAsTimeNullable(OneOf<LiteralTime, LiteralTimeNullable> input)
        : base(input) { }
}
