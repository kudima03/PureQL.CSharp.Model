using OneOf;
using PureQL.CSharp.Model.Literals;
using PureQL.CSharp.Model.Parameters;

namespace PureQL.CSharp.Model.TotalExpressions;

public sealed class IntegerTotal
    : OneOfBase<
        ParamInteger,
        LiteralInteger,
        ArithmeticIntegerTotal,
        RoundingIntegerTotal,
        DateDiffDaysIntegerTotal,
        ConditionalIntegerTotal,
        AggregateIntegerTotal
    >
{
    public IntegerTotal(ParamInteger value)
        : this(
            (OneOf<
                ParamInteger,
                LiteralInteger,
                ArithmeticIntegerTotal,
                RoundingIntegerTotal,
                DateDiffDaysIntegerTotal,
                ConditionalIntegerTotal,
                AggregateIntegerTotal
            >)
                value
        )
    { }

    public IntegerTotal(LiteralInteger value)
        : this(
            (OneOf<
                ParamInteger,
                LiteralInteger,
                ArithmeticIntegerTotal,
                RoundingIntegerTotal,
                DateDiffDaysIntegerTotal,
                ConditionalIntegerTotal,
                AggregateIntegerTotal
            >)
                value
        )
    { }

    public IntegerTotal(ArithmeticIntegerTotal value)
        : this(
            (OneOf<
                ParamInteger,
                LiteralInteger,
                ArithmeticIntegerTotal,
                RoundingIntegerTotal,
                DateDiffDaysIntegerTotal,
                ConditionalIntegerTotal,
                AggregateIntegerTotal
            >)
                value
        )
    { }

    public IntegerTotal(RoundingIntegerTotal value)
        : this(
            (OneOf<
                ParamInteger,
                LiteralInteger,
                ArithmeticIntegerTotal,
                RoundingIntegerTotal,
                DateDiffDaysIntegerTotal,
                ConditionalIntegerTotal,
                AggregateIntegerTotal
            >)
                value
        )
    { }

    public IntegerTotal(DateDiffDaysIntegerTotal value)
        : this(
            (OneOf<
                ParamInteger,
                LiteralInteger,
                ArithmeticIntegerTotal,
                RoundingIntegerTotal,
                DateDiffDaysIntegerTotal,
                ConditionalIntegerTotal,
                AggregateIntegerTotal
            >)
                value
        )
    { }

    public IntegerTotal(ConditionalIntegerTotal value)
        : this(
            (OneOf<
                ParamInteger,
                LiteralInteger,
                ArithmeticIntegerTotal,
                RoundingIntegerTotal,
                DateDiffDaysIntegerTotal,
                ConditionalIntegerTotal,
                AggregateIntegerTotal
            >)
                value
        )
    { }

    public IntegerTotal(AggregateIntegerTotal value)
        : this(
            (OneOf<
                ParamInteger,
                LiteralInteger,
                ArithmeticIntegerTotal,
                RoundingIntegerTotal,
                DateDiffDaysIntegerTotal,
                ConditionalIntegerTotal,
                AggregateIntegerTotal
            >)
                value
        )
    { }

    private IntegerTotal(
        OneOf<
            ParamInteger,
            LiteralInteger,
            ArithmeticIntegerTotal,
            RoundingIntegerTotal,
            DateDiffDaysIntegerTotal,
            ConditionalIntegerTotal,
            AggregateIntegerTotal
        > input
    )
        : base(input) { }
}
