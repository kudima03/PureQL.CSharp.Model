using OneOf;
using PureQL.CSharp.Model.Fields;
using PureQL.CSharp.Model.Literals;
using PureQL.CSharp.Model.Parameters;

namespace PureQL.CSharp.Model.ProjectionExpressions;

public sealed class IntegerProjection
    : OneOfBase<
        FieldInteger,
        ParamInteger,
        LiteralInteger,
        ArithmeticIntegerProjection,
        RoundingIntegerProjection,
        DateDiffDaysIntegerProjection,
        ConditionalIntegerProjection,
        AggregateIntegerProjection
    >
{
    public IntegerProjection(FieldInteger value)
        : this(
            (OneOf<
                FieldInteger,
                ParamInteger,
                LiteralInteger,
                ArithmeticIntegerProjection,
                RoundingIntegerProjection,
                DateDiffDaysIntegerProjection,
                ConditionalIntegerProjection,
                AggregateIntegerProjection
            >)
                value
        )
    { }

    public IntegerProjection(ParamInteger value)
        : this(
            (OneOf<
                FieldInteger,
                ParamInteger,
                LiteralInteger,
                ArithmeticIntegerProjection,
                RoundingIntegerProjection,
                DateDiffDaysIntegerProjection,
                ConditionalIntegerProjection,
                AggregateIntegerProjection
            >)
                value
        )
    { }

    public IntegerProjection(LiteralInteger value)
        : this(
            (OneOf<
                FieldInteger,
                ParamInteger,
                LiteralInteger,
                ArithmeticIntegerProjection,
                RoundingIntegerProjection,
                DateDiffDaysIntegerProjection,
                ConditionalIntegerProjection,
                AggregateIntegerProjection
            >)
                value
        )
    { }

    public IntegerProjection(ArithmeticIntegerProjection value)
        : this(
            (OneOf<
                FieldInteger,
                ParamInteger,
                LiteralInteger,
                ArithmeticIntegerProjection,
                RoundingIntegerProjection,
                DateDiffDaysIntegerProjection,
                ConditionalIntegerProjection,
                AggregateIntegerProjection
            >)
                value
        )
    { }

    public IntegerProjection(RoundingIntegerProjection value)
        : this(
            (OneOf<
                FieldInteger,
                ParamInteger,
                LiteralInteger,
                ArithmeticIntegerProjection,
                RoundingIntegerProjection,
                DateDiffDaysIntegerProjection,
                ConditionalIntegerProjection,
                AggregateIntegerProjection
            >)
                value
        )
    { }

    public IntegerProjection(DateDiffDaysIntegerProjection value)
        : this(
            (OneOf<
                FieldInteger,
                ParamInteger,
                LiteralInteger,
                ArithmeticIntegerProjection,
                RoundingIntegerProjection,
                DateDiffDaysIntegerProjection,
                ConditionalIntegerProjection,
                AggregateIntegerProjection
            >)
                value
        )
    { }

    public IntegerProjection(ConditionalIntegerProjection value)
        : this(
            (OneOf<
                FieldInteger,
                ParamInteger,
                LiteralInteger,
                ArithmeticIntegerProjection,
                RoundingIntegerProjection,
                DateDiffDaysIntegerProjection,
                ConditionalIntegerProjection,
                AggregateIntegerProjection
            >)
                value
        )
    { }

    public IntegerProjection(AggregateIntegerProjection value)
        : this(
            (OneOf<
                FieldInteger,
                ParamInteger,
                LiteralInteger,
                ArithmeticIntegerProjection,
                RoundingIntegerProjection,
                DateDiffDaysIntegerProjection,
                ConditionalIntegerProjection,
                AggregateIntegerProjection
            >)
                value
        )
    { }

    private IntegerProjection(
        OneOf<
            FieldInteger,
            ParamInteger,
            LiteralInteger,
            ArithmeticIntegerProjection,
            RoundingIntegerProjection,
            DateDiffDaysIntegerProjection,
            ConditionalIntegerProjection,
            AggregateIntegerProjection
        > input
    )
        : base(input) { }
}
