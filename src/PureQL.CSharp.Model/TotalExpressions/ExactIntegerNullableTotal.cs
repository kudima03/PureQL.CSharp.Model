using OneOf;
using PureQL.CSharp.Model.Literals;
using PureQL.CSharp.Model.Parameters;

namespace PureQL.CSharp.Model.TotalExpressions;

public sealed class ExactIntegerNullableTotal
    : OneOfBase<
        ParamIntegerNullable,
        LiteralIntegerNullable,
        ArithmeticIntegerNullableTotal,
        RoundingIntegerNullableTotal,
        DateDiffDaysIntegerNullableTotal,
        ConditionalIntegerNullableTotal,
        AggregateIntegerNullableTotal
    >
{
    public ExactIntegerNullableTotal(ParamIntegerNullable value)
        : this(
            (OneOf<
                ParamIntegerNullable,
                LiteralIntegerNullable,
                ArithmeticIntegerNullableTotal,
                RoundingIntegerNullableTotal,
                DateDiffDaysIntegerNullableTotal,
                ConditionalIntegerNullableTotal,
                AggregateIntegerNullableTotal
            >)
                value
        )
    { }

    public ExactIntegerNullableTotal(LiteralIntegerNullable value)
        : this(
            (OneOf<
                ParamIntegerNullable,
                LiteralIntegerNullable,
                ArithmeticIntegerNullableTotal,
                RoundingIntegerNullableTotal,
                DateDiffDaysIntegerNullableTotal,
                ConditionalIntegerNullableTotal,
                AggregateIntegerNullableTotal
            >)
                value
        )
    { }

    public ExactIntegerNullableTotal(ArithmeticIntegerNullableTotal value)
        : this(
            (OneOf<
                ParamIntegerNullable,
                LiteralIntegerNullable,
                ArithmeticIntegerNullableTotal,
                RoundingIntegerNullableTotal,
                DateDiffDaysIntegerNullableTotal,
                ConditionalIntegerNullableTotal,
                AggregateIntegerNullableTotal
            >)
                value
        )
    { }

    public ExactIntegerNullableTotal(RoundingIntegerNullableTotal value)
        : this(
            (OneOf<
                ParamIntegerNullable,
                LiteralIntegerNullable,
                ArithmeticIntegerNullableTotal,
                RoundingIntegerNullableTotal,
                DateDiffDaysIntegerNullableTotal,
                ConditionalIntegerNullableTotal,
                AggregateIntegerNullableTotal
            >)
                value
        )
    { }

    public ExactIntegerNullableTotal(DateDiffDaysIntegerNullableTotal value)
        : this(
            (OneOf<
                ParamIntegerNullable,
                LiteralIntegerNullable,
                ArithmeticIntegerNullableTotal,
                RoundingIntegerNullableTotal,
                DateDiffDaysIntegerNullableTotal,
                ConditionalIntegerNullableTotal,
                AggregateIntegerNullableTotal
            >)
                value
        )
    { }

    public ExactIntegerNullableTotal(ConditionalIntegerNullableTotal value)
        : this(
            (OneOf<
                ParamIntegerNullable,
                LiteralIntegerNullable,
                ArithmeticIntegerNullableTotal,
                RoundingIntegerNullableTotal,
                DateDiffDaysIntegerNullableTotal,
                ConditionalIntegerNullableTotal,
                AggregateIntegerNullableTotal
            >)
                value
        )
    { }

    public ExactIntegerNullableTotal(AggregateIntegerNullableTotal value)
        : this(
            (OneOf<
                ParamIntegerNullable,
                LiteralIntegerNullable,
                ArithmeticIntegerNullableTotal,
                RoundingIntegerNullableTotal,
                DateDiffDaysIntegerNullableTotal,
                ConditionalIntegerNullableTotal,
                AggregateIntegerNullableTotal
            >)
                value
        )
    { }

    private ExactIntegerNullableTotal(
        OneOf<
            ParamIntegerNullable,
            LiteralIntegerNullable,
            ArithmeticIntegerNullableTotal,
            RoundingIntegerNullableTotal,
            DateDiffDaysIntegerNullableTotal,
            ConditionalIntegerNullableTotal,
            AggregateIntegerNullableTotal
        > input
    )
        : base(input) { }
}
