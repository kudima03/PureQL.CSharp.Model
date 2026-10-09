using OneOf;
using PureQL.CSharp.Model.Keys;
using PureQL.CSharp.Model.Literals;
using PureQL.CSharp.Model.Parameters;

namespace PureQL.CSharp.Model.GroupExpressions;

public sealed class DecimalGroup
    : OneOfBase<
        KeyAsDecimal,
        ParamAsDecimal,
        LiteralAsDecimal,
        ArithmeticDecimalGroup,
        RoundingDecimalGroup,
        DifferenceDecimalGroup,
        ConditionalDecimalGroup,
        AggregateDecimalGroup
    >
{
    public DecimalGroup(KeyAsDecimal value)
        : this(
            (OneOf<
                KeyAsDecimal,
                ParamAsDecimal,
                LiteralAsDecimal,
                ArithmeticDecimalGroup,
                RoundingDecimalGroup,
                DifferenceDecimalGroup,
                ConditionalDecimalGroup,
                AggregateDecimalGroup
            >)
                value
        )
    { }

    public DecimalGroup(ParamAsDecimal value)
        : this(
            (OneOf<
                KeyAsDecimal,
                ParamAsDecimal,
                LiteralAsDecimal,
                ArithmeticDecimalGroup,
                RoundingDecimalGroup,
                DifferenceDecimalGroup,
                ConditionalDecimalGroup,
                AggregateDecimalGroup
            >)
                value
        )
    { }

    public DecimalGroup(LiteralAsDecimal value)
        : this(
            (OneOf<
                KeyAsDecimal,
                ParamAsDecimal,
                LiteralAsDecimal,
                ArithmeticDecimalGroup,
                RoundingDecimalGroup,
                DifferenceDecimalGroup,
                ConditionalDecimalGroup,
                AggregateDecimalGroup
            >)
                value
        )
    { }

    public DecimalGroup(ArithmeticDecimalGroup value)
        : this(
            (OneOf<
                KeyAsDecimal,
                ParamAsDecimal,
                LiteralAsDecimal,
                ArithmeticDecimalGroup,
                RoundingDecimalGroup,
                DifferenceDecimalGroup,
                ConditionalDecimalGroup,
                AggregateDecimalGroup
            >)
                value
        )
    { }

    public DecimalGroup(RoundingDecimalGroup value)
        : this(
            (OneOf<
                KeyAsDecimal,
                ParamAsDecimal,
                LiteralAsDecimal,
                ArithmeticDecimalGroup,
                RoundingDecimalGroup,
                DifferenceDecimalGroup,
                ConditionalDecimalGroup,
                AggregateDecimalGroup
            >)
                value
        )
    { }

    public DecimalGroup(DifferenceDecimalGroup value)
        : this(
            (OneOf<
                KeyAsDecimal,
                ParamAsDecimal,
                LiteralAsDecimal,
                ArithmeticDecimalGroup,
                RoundingDecimalGroup,
                DifferenceDecimalGroup,
                ConditionalDecimalGroup,
                AggregateDecimalGroup
            >)
                value
        )
    { }

    public DecimalGroup(ConditionalDecimalGroup value)
        : this(
            (OneOf<
                KeyAsDecimal,
                ParamAsDecimal,
                LiteralAsDecimal,
                ArithmeticDecimalGroup,
                RoundingDecimalGroup,
                DifferenceDecimalGroup,
                ConditionalDecimalGroup,
                AggregateDecimalGroup
            >)
                value
        )
    { }

    public DecimalGroup(AggregateDecimalGroup value)
        : this(
            (OneOf<
                KeyAsDecimal,
                ParamAsDecimal,
                LiteralAsDecimal,
                ArithmeticDecimalGroup,
                RoundingDecimalGroup,
                DifferenceDecimalGroup,
                ConditionalDecimalGroup,
                AggregateDecimalGroup
            >)
                value
        )
    { }

    private DecimalGroup(
        OneOf<
            KeyAsDecimal,
            ParamAsDecimal,
            LiteralAsDecimal,
            ArithmeticDecimalGroup,
            RoundingDecimalGroup,
            DifferenceDecimalGroup,
            ConditionalDecimalGroup,
            AggregateDecimalGroup
        > input
    )
        : base(input) { }
}
