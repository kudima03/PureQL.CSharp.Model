using OneOf;
using PureQL.CSharp.Model.Keys;
using PureQL.CSharp.Model.Literals;
using PureQL.CSharp.Model.Parameters;

namespace PureQL.CSharp.Model.GroupExpressions;

public sealed class ExactDecimalGroup
    : OneOfBase<
        KeyDecimal,
        ParamDecimal,
        LiteralDecimal,
        ArithmeticDecimalGroup,
        RoundDecimalGroup,
        DifferenceDecimalGroup,
        ConditionalDecimalGroup,
        AggregateDecimalGroup
    >
{
    public ExactDecimalGroup(KeyDecimal value)
        : this(
            (OneOf<
                KeyDecimal,
                ParamDecimal,
                LiteralDecimal,
                ArithmeticDecimalGroup,
                RoundDecimalGroup,
                DifferenceDecimalGroup,
                ConditionalDecimalGroup,
                AggregateDecimalGroup
            >)
                value
        )
    { }

    public ExactDecimalGroup(ParamDecimal value)
        : this(
            (OneOf<
                KeyDecimal,
                ParamDecimal,
                LiteralDecimal,
                ArithmeticDecimalGroup,
                RoundDecimalGroup,
                DifferenceDecimalGroup,
                ConditionalDecimalGroup,
                AggregateDecimalGroup
            >)
                value
        )
    { }

    public ExactDecimalGroup(LiteralDecimal value)
        : this(
            (OneOf<
                KeyDecimal,
                ParamDecimal,
                LiteralDecimal,
                ArithmeticDecimalGroup,
                RoundDecimalGroup,
                DifferenceDecimalGroup,
                ConditionalDecimalGroup,
                AggregateDecimalGroup
            >)
                value
        )
    { }

    public ExactDecimalGroup(ArithmeticDecimalGroup value)
        : this(
            (OneOf<
                KeyDecimal,
                ParamDecimal,
                LiteralDecimal,
                ArithmeticDecimalGroup,
                RoundDecimalGroup,
                DifferenceDecimalGroup,
                ConditionalDecimalGroup,
                AggregateDecimalGroup
            >)
                value
        )
    { }

    public ExactDecimalGroup(RoundDecimalGroup value)
        : this(
            (OneOf<
                KeyDecimal,
                ParamDecimal,
                LiteralDecimal,
                ArithmeticDecimalGroup,
                RoundDecimalGroup,
                DifferenceDecimalGroup,
                ConditionalDecimalGroup,
                AggregateDecimalGroup
            >)
                value
        )
    { }

    public ExactDecimalGroup(DifferenceDecimalGroup value)
        : this(
            (OneOf<
                KeyDecimal,
                ParamDecimal,
                LiteralDecimal,
                ArithmeticDecimalGroup,
                RoundDecimalGroup,
                DifferenceDecimalGroup,
                ConditionalDecimalGroup,
                AggregateDecimalGroup
            >)
                value
        )
    { }

    public ExactDecimalGroup(ConditionalDecimalGroup value)
        : this(
            (OneOf<
                KeyDecimal,
                ParamDecimal,
                LiteralDecimal,
                ArithmeticDecimalGroup,
                RoundDecimalGroup,
                DifferenceDecimalGroup,
                ConditionalDecimalGroup,
                AggregateDecimalGroup
            >)
                value
        )
    { }

    public ExactDecimalGroup(AggregateDecimalGroup value)
        : this(
            (OneOf<
                KeyDecimal,
                ParamDecimal,
                LiteralDecimal,
                ArithmeticDecimalGroup,
                RoundDecimalGroup,
                DifferenceDecimalGroup,
                ConditionalDecimalGroup,
                AggregateDecimalGroup
            >)
                value
        )
    { }

    private ExactDecimalGroup(
        OneOf<
            KeyDecimal,
            ParamDecimal,
            LiteralDecimal,
            ArithmeticDecimalGroup,
            RoundDecimalGroup,
            DifferenceDecimalGroup,
            ConditionalDecimalGroup,
            AggregateDecimalGroup
        > input
    )
        : base(input) { }
}
