using OneOf;

namespace PureQL.CSharp.Model.Literals;

public sealed class LiteralAsBooleanNullable
    : OneOfBase<LiteralBoolean, LiteralBooleanNullable>
{
    public LiteralAsBooleanNullable(LiteralBoolean value)
        : this((OneOf<LiteralBoolean, LiteralBooleanNullable>)value) { }

    public LiteralAsBooleanNullable(LiteralBooleanNullable value)
        : this((OneOf<LiteralBoolean, LiteralBooleanNullable>)value) { }

    private LiteralAsBooleanNullable(OneOf<LiteralBoolean, LiteralBooleanNullable> input)
        : base(input) { }
}
