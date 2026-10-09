using OneOf;

namespace PureQL.CSharp.Model.Literals;

public sealed class LiteralAsStringNullable
    : OneOfBase<LiteralString, LiteralStringNullable>
{
    public LiteralAsStringNullable(LiteralString value)
        : this((OneOf<LiteralString, LiteralStringNullable>)value) { }

    public LiteralAsStringNullable(LiteralStringNullable value)
        : this((OneOf<LiteralString, LiteralStringNullable>)value) { }

    private LiteralAsStringNullable(OneOf<LiteralString, LiteralStringNullable> input)
        : base(input) { }
}
