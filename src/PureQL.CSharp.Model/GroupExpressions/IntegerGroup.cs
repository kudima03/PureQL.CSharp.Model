using OneOf;
using PureQL.CSharp.Model.Keys;
using PureQL.CSharp.Model.Literals;
using PureQL.CSharp.Model.Parameters;

namespace PureQL.CSharp.Model.GroupExpressions;

public sealed class IntegerGroup
    : OneOfBase<
        KeyInteger,
        ParamInteger,
        LiteralInteger,
        ArithmeticIntegerGroup,
        RoundingIntegerGroup,
        DateDiffDaysIntegerGroup,
        ConditionalIntegerGroup,
        AggregateIntegerGroup
    >
{
    public IntegerGroup(KeyInteger value)
        : this(
            (OneOf<
                KeyInteger,
                ParamInteger,
                LiteralInteger,
                ArithmeticIntegerGroup,
                RoundingIntegerGroup,
                DateDiffDaysIntegerGroup,
                ConditionalIntegerGroup,
                AggregateIntegerGroup
            >)
                value
        )
    { }

    public IntegerGroup(ParamInteger value)
        : this(
            (OneOf<
                KeyInteger,
                ParamInteger,
                LiteralInteger,
                ArithmeticIntegerGroup,
                RoundingIntegerGroup,
                DateDiffDaysIntegerGroup,
                ConditionalIntegerGroup,
                AggregateIntegerGroup
            >)
                value
        )
    { }

    public IntegerGroup(LiteralInteger value)
        : this(
            (OneOf<
                KeyInteger,
                ParamInteger,
                LiteralInteger,
                ArithmeticIntegerGroup,
                RoundingIntegerGroup,
                DateDiffDaysIntegerGroup,
                ConditionalIntegerGroup,
                AggregateIntegerGroup
            >)
                value
        )
    { }

    public IntegerGroup(ArithmeticIntegerGroup value)
        : this(
            (OneOf<
                KeyInteger,
                ParamInteger,
                LiteralInteger,
                ArithmeticIntegerGroup,
                RoundingIntegerGroup,
                DateDiffDaysIntegerGroup,
                ConditionalIntegerGroup,
                AggregateIntegerGroup
            >)
                value
        )
    { }

    public IntegerGroup(RoundingIntegerGroup value)
        : this(
            (OneOf<
                KeyInteger,
                ParamInteger,
                LiteralInteger,
                ArithmeticIntegerGroup,
                RoundingIntegerGroup,
                DateDiffDaysIntegerGroup,
                ConditionalIntegerGroup,
                AggregateIntegerGroup
            >)
                value
        )
    { }

    public IntegerGroup(DateDiffDaysIntegerGroup value)
        : this(
            (OneOf<
                KeyInteger,
                ParamInteger,
                LiteralInteger,
                ArithmeticIntegerGroup,
                RoundingIntegerGroup,
                DateDiffDaysIntegerGroup,
                ConditionalIntegerGroup,
                AggregateIntegerGroup
            >)
                value
        )
    { }

    public IntegerGroup(ConditionalIntegerGroup value)
        : this(
            (OneOf<
                KeyInteger,
                ParamInteger,
                LiteralInteger,
                ArithmeticIntegerGroup,
                RoundingIntegerGroup,
                DateDiffDaysIntegerGroup,
                ConditionalIntegerGroup,
                AggregateIntegerGroup
            >)
                value
        )
    { }

    public IntegerGroup(AggregateIntegerGroup value)
        : this(
            (OneOf<
                KeyInteger,
                ParamInteger,
                LiteralInteger,
                ArithmeticIntegerGroup,
                RoundingIntegerGroup,
                DateDiffDaysIntegerGroup,
                ConditionalIntegerGroup,
                AggregateIntegerGroup
            >)
                value
        )
    { }

    private IntegerGroup(
        OneOf<
            KeyInteger,
            ParamInteger,
            LiteralInteger,
            ArithmeticIntegerGroup,
            RoundingIntegerGroup,
            DateDiffDaysIntegerGroup,
            ConditionalIntegerGroup,
            AggregateIntegerGroup
        > input
    )
        : base(input) { }
}
