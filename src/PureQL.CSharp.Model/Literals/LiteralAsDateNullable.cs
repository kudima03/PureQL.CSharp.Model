using OneOf;

namespace PureQL.CSharp.Model.Literals;

public sealed class LiteralAsDateNullable : OneOfBase<LiteralDate, LiteralDateNullable>
{
    public LiteralAsDateNullable(LiteralDate value)
        : this((OneOf<LiteralDate, LiteralDateNullable>)value) { }

    public LiteralAsDateNullable(LiteralDateNullable value)
        : this((OneOf<LiteralDate, LiteralDateNullable>)value) { }

    private LiteralAsDateNullable(OneOf<LiteralDate, LiteralDateNullable> input)
        : base(input) { }
}
