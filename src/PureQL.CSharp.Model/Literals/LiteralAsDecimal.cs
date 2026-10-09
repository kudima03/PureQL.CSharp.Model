using OneOf;

namespace PureQL.CSharp.Model.Literals;

public sealed class LiteralAsDecimal : OneOfBase<LiteralDecimal, LiteralInteger>
{
    public LiteralAsDecimal(LiteralDecimal value)
        : this((OneOf<LiteralDecimal, LiteralInteger>)value) { }

    public LiteralAsDecimal(LiteralInteger value)
        : this((OneOf<LiteralDecimal, LiteralInteger>)value) { }

    private LiteralAsDecimal(OneOf<LiteralDecimal, LiteralInteger> input)
        : base(input) { }
}
