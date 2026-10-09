using OneOf;
using PureQL.CSharp.Model.Fields;
using PureQL.CSharp.Model.Literals;
using PureQL.CSharp.Model.Parameters;

namespace PureQL.CSharp.Model.ProjectionExpressions;

public sealed class IntegerNullableProjection
    : OneOfBase<
        FieldAsIntegerNullable,
        ParamAsIntegerNullable,
        LiteralAsIntegerNullable,
        ArithmeticIntegerNullableProjection,
        RoundingIntegerNullableProjection,
        DateDiffDaysIntegerNullableProjection,
        ConditionalIntegerNullableProjection,
        AggregateIntegerNullableProjection
    >
{
    public IntegerNullableProjection(FieldAsIntegerNullable value)
        : this(
            (OneOf<
                FieldAsIntegerNullable,
                ParamAsIntegerNullable,
                LiteralAsIntegerNullable,
                ArithmeticIntegerNullableProjection,
                RoundingIntegerNullableProjection,
                DateDiffDaysIntegerNullableProjection,
                ConditionalIntegerNullableProjection,
                AggregateIntegerNullableProjection
            >)
                value
        )
    { }

    public IntegerNullableProjection(ParamAsIntegerNullable value)
        : this(
            (OneOf<
                FieldAsIntegerNullable,
                ParamAsIntegerNullable,
                LiteralAsIntegerNullable,
                ArithmeticIntegerNullableProjection,
                RoundingIntegerNullableProjection,
                DateDiffDaysIntegerNullableProjection,
                ConditionalIntegerNullableProjection,
                AggregateIntegerNullableProjection
            >)
                value
        )
    { }

    public IntegerNullableProjection(LiteralAsIntegerNullable value)
        : this(
            (OneOf<
                FieldAsIntegerNullable,
                ParamAsIntegerNullable,
                LiteralAsIntegerNullable,
                ArithmeticIntegerNullableProjection,
                RoundingIntegerNullableProjection,
                DateDiffDaysIntegerNullableProjection,
                ConditionalIntegerNullableProjection,
                AggregateIntegerNullableProjection
            >)
                value
        )
    { }

    public IntegerNullableProjection(ArithmeticIntegerNullableProjection value)
        : this(
            (OneOf<
                FieldAsIntegerNullable,
                ParamAsIntegerNullable,
                LiteralAsIntegerNullable,
                ArithmeticIntegerNullableProjection,
                RoundingIntegerNullableProjection,
                DateDiffDaysIntegerNullableProjection,
                ConditionalIntegerNullableProjection,
                AggregateIntegerNullableProjection
            >)
                value
        )
    { }

    public IntegerNullableProjection(RoundingIntegerNullableProjection value)
        : this(
            (OneOf<
                FieldAsIntegerNullable,
                ParamAsIntegerNullable,
                LiteralAsIntegerNullable,
                ArithmeticIntegerNullableProjection,
                RoundingIntegerNullableProjection,
                DateDiffDaysIntegerNullableProjection,
                ConditionalIntegerNullableProjection,
                AggregateIntegerNullableProjection
            >)
                value
        )
    { }

    public IntegerNullableProjection(DateDiffDaysIntegerNullableProjection value)
        : this(
            (OneOf<
                FieldAsIntegerNullable,
                ParamAsIntegerNullable,
                LiteralAsIntegerNullable,
                ArithmeticIntegerNullableProjection,
                RoundingIntegerNullableProjection,
                DateDiffDaysIntegerNullableProjection,
                ConditionalIntegerNullableProjection,
                AggregateIntegerNullableProjection
            >)
                value
        )
    { }

    public IntegerNullableProjection(ConditionalIntegerNullableProjection value)
        : this(
            (OneOf<
                FieldAsIntegerNullable,
                ParamAsIntegerNullable,
                LiteralAsIntegerNullable,
                ArithmeticIntegerNullableProjection,
                RoundingIntegerNullableProjection,
                DateDiffDaysIntegerNullableProjection,
                ConditionalIntegerNullableProjection,
                AggregateIntegerNullableProjection
            >)
                value
        )
    { }

    public IntegerNullableProjection(AggregateIntegerNullableProjection value)
        : this(
            (OneOf<
                FieldAsIntegerNullable,
                ParamAsIntegerNullable,
                LiteralAsIntegerNullable,
                ArithmeticIntegerNullableProjection,
                RoundingIntegerNullableProjection,
                DateDiffDaysIntegerNullableProjection,
                ConditionalIntegerNullableProjection,
                AggregateIntegerNullableProjection
            >)
                value
        )
    { }

    private IntegerNullableProjection(
        OneOf<
            FieldAsIntegerNullable,
            ParamAsIntegerNullable,
            LiteralAsIntegerNullable,
            ArithmeticIntegerNullableProjection,
            RoundingIntegerNullableProjection,
            DateDiffDaysIntegerNullableProjection,
            ConditionalIntegerNullableProjection,
            AggregateIntegerNullableProjection
        > input
    )
        : base(input) { }
}
