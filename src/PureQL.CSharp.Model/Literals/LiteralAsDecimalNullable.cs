using OneOf;

namespace PureQL.CSharp.Model.Literals;

public sealed class LiteralAsDecimalNullable
    : OneOfBase<
        LiteralDecimal,
        LiteralDecimalNullable,
        LiteralInteger,
        LiteralIntegerNullable
    >
{
    public LiteralAsDecimalNullable(LiteralDecimal value)
        : this(
            (OneOf<
                LiteralDecimal,
                LiteralDecimalNullable,
                LiteralInteger,
                LiteralIntegerNullable
            >)
                value
        )
    { }

    public LiteralAsDecimalNullable(LiteralDecimalNullable value)
        : this(
            (OneOf<
                LiteralDecimal,
                LiteralDecimalNullable,
                LiteralInteger,
                LiteralIntegerNullable
            >)
                value
        )
    { }

    public LiteralAsDecimalNullable(LiteralInteger value)
        : this(
            (OneOf<
                LiteralDecimal,
                LiteralDecimalNullable,
                LiteralInteger,
                LiteralIntegerNullable
            >)
                value
        )
    { }

    public LiteralAsDecimalNullable(LiteralIntegerNullable value)
        : this(
            (OneOf<
                LiteralDecimal,
                LiteralDecimalNullable,
                LiteralInteger,
                LiteralIntegerNullable
            >)
                value
        )
    { }

    private LiteralAsDecimalNullable(
        OneOf<
            LiteralDecimal,
            LiteralDecimalNullable,
            LiteralInteger,
            LiteralIntegerNullable
        > input
    )
        : base(input) { }
}
