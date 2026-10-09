using OneOf;

namespace PureQL.CSharp.Model.Literals;

public sealed class LiteralAsIntegerNullable
    : OneOfBase<LiteralInteger, LiteralIntegerNullable>
{
    public LiteralAsIntegerNullable(LiteralInteger value)
        : this((OneOf<LiteralInteger, LiteralIntegerNullable>)value) { }

    public LiteralAsIntegerNullable(LiteralIntegerNullable value)
        : this((OneOf<LiteralInteger, LiteralIntegerNullable>)value) { }

    private LiteralAsIntegerNullable(OneOf<LiteralInteger, LiteralIntegerNullable> input)
        : base(input) { }
}
