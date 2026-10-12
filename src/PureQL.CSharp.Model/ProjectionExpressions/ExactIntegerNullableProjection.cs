using OneOf;
using PureQL.CSharp.Model.Fields;
using PureQL.CSharp.Model.Literals;
using PureQL.CSharp.Model.Parameters;

namespace PureQL.CSharp.Model.ProjectionExpressions;

public sealed class ExactIntegerNullableProjection
    : OneOfBase<
        FieldIntegerNullable,
        ParamIntegerNullable,
        LiteralIntegerNullable,
        ArithmeticIntegerNullableProjection,
        RoundingIntegerNullableProjection,
        DateDiffDaysIntegerNullableProjection,
        ConditionalIntegerNullableProjection,
        AggregateIntegerNullableProjection
    >
{
    public ExactIntegerNullableProjection(FieldIntegerNullable value)
        : this(
            (OneOf<
                FieldIntegerNullable,
                ParamIntegerNullable,
                LiteralIntegerNullable,
                ArithmeticIntegerNullableProjection,
                RoundingIntegerNullableProjection,
                DateDiffDaysIntegerNullableProjection,
                ConditionalIntegerNullableProjection,
                AggregateIntegerNullableProjection
            >)
                value
        )
    { }

    public ExactIntegerNullableProjection(ParamIntegerNullable value)
        : this(
            (OneOf<
                FieldIntegerNullable,
                ParamIntegerNullable,
                LiteralIntegerNullable,
                ArithmeticIntegerNullableProjection,
                RoundingIntegerNullableProjection,
                DateDiffDaysIntegerNullableProjection,
                ConditionalIntegerNullableProjection,
                AggregateIntegerNullableProjection
            >)
                value
        )
    { }

    public ExactIntegerNullableProjection(LiteralIntegerNullable value)
        : this(
            (OneOf<
                FieldIntegerNullable,
                ParamIntegerNullable,
                LiteralIntegerNullable,
                ArithmeticIntegerNullableProjection,
                RoundingIntegerNullableProjection,
                DateDiffDaysIntegerNullableProjection,
                ConditionalIntegerNullableProjection,
                AggregateIntegerNullableProjection
            >)
                value
        )
    { }

    public ExactIntegerNullableProjection(ArithmeticIntegerNullableProjection value)
        : this(
            (OneOf<
                FieldIntegerNullable,
                ParamIntegerNullable,
                LiteralIntegerNullable,
                ArithmeticIntegerNullableProjection,
                RoundingIntegerNullableProjection,
                DateDiffDaysIntegerNullableProjection,
                ConditionalIntegerNullableProjection,
                AggregateIntegerNullableProjection
            >)
                value
        )
    { }

    public ExactIntegerNullableProjection(RoundingIntegerNullableProjection value)
        : this(
            (OneOf<
                FieldIntegerNullable,
                ParamIntegerNullable,
                LiteralIntegerNullable,
                ArithmeticIntegerNullableProjection,
                RoundingIntegerNullableProjection,
                DateDiffDaysIntegerNullableProjection,
                ConditionalIntegerNullableProjection,
                AggregateIntegerNullableProjection
            >)
                value
        )
    { }

    public ExactIntegerNullableProjection(DateDiffDaysIntegerNullableProjection value)
        : this(
            (OneOf<
                FieldIntegerNullable,
                ParamIntegerNullable,
                LiteralIntegerNullable,
                ArithmeticIntegerNullableProjection,
                RoundingIntegerNullableProjection,
                DateDiffDaysIntegerNullableProjection,
                ConditionalIntegerNullableProjection,
                AggregateIntegerNullableProjection
            >)
                value
        )
    { }

    public ExactIntegerNullableProjection(ConditionalIntegerNullableProjection value)
        : this(
            (OneOf<
                FieldIntegerNullable,
                ParamIntegerNullable,
                LiteralIntegerNullable,
                ArithmeticIntegerNullableProjection,
                RoundingIntegerNullableProjection,
                DateDiffDaysIntegerNullableProjection,
                ConditionalIntegerNullableProjection,
                AggregateIntegerNullableProjection
            >)
                value
        )
    { }

    public ExactIntegerNullableProjection(AggregateIntegerNullableProjection value)
        : this(
            (OneOf<
                FieldIntegerNullable,
                ParamIntegerNullable,
                LiteralIntegerNullable,
                ArithmeticIntegerNullableProjection,
                RoundingIntegerNullableProjection,
                DateDiffDaysIntegerNullableProjection,
                ConditionalIntegerNullableProjection,
                AggregateIntegerNullableProjection
            >)
                value
        )
    { }

    private ExactIntegerNullableProjection(
        OneOf<
            FieldIntegerNullable,
            ParamIntegerNullable,
            LiteralIntegerNullable,
            ArithmeticIntegerNullableProjection,
            RoundingIntegerNullableProjection,
            DateDiffDaysIntegerNullableProjection,
            ConditionalIntegerNullableProjection,
            AggregateIntegerNullableProjection
        > input
    )
        : base(input) { }
}
