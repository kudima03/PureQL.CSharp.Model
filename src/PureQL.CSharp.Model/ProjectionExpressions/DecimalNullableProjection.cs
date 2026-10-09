using OneOf;
using PureQL.CSharp.Model.Fields;
using PureQL.CSharp.Model.Literals;
using PureQL.CSharp.Model.Parameters;

namespace PureQL.CSharp.Model.ProjectionExpressions;

public sealed class DecimalNullableProjection
    : OneOfBase<
        FieldAsDecimalNullable,
        ParamAsDecimalNullable,
        LiteralAsDecimalNullable,
        ArithmeticDecimalNullableProjection,
        RoundingDecimalNullableProjection,
        DifferenceDecimalNullableProjection,
        ConditionalDecimalNullableProjection,
        AggregateDecimalNullableProjection
    >
{
    public DecimalNullableProjection(FieldAsDecimalNullable value)
        : this(
            (OneOf<
                FieldAsDecimalNullable,
                ParamAsDecimalNullable,
                LiteralAsDecimalNullable,
                ArithmeticDecimalNullableProjection,
                RoundingDecimalNullableProjection,
                DifferenceDecimalNullableProjection,
                ConditionalDecimalNullableProjection,
                AggregateDecimalNullableProjection
            >)
                value
        )
    { }

    public DecimalNullableProjection(ParamAsDecimalNullable value)
        : this(
            (OneOf<
                FieldAsDecimalNullable,
                ParamAsDecimalNullable,
                LiteralAsDecimalNullable,
                ArithmeticDecimalNullableProjection,
                RoundingDecimalNullableProjection,
                DifferenceDecimalNullableProjection,
                ConditionalDecimalNullableProjection,
                AggregateDecimalNullableProjection
            >)
                value
        )
    { }

    public DecimalNullableProjection(LiteralAsDecimalNullable value)
        : this(
            (OneOf<
                FieldAsDecimalNullable,
                ParamAsDecimalNullable,
                LiteralAsDecimalNullable,
                ArithmeticDecimalNullableProjection,
                RoundingDecimalNullableProjection,
                DifferenceDecimalNullableProjection,
                ConditionalDecimalNullableProjection,
                AggregateDecimalNullableProjection
            >)
                value
        )
    { }

    public DecimalNullableProjection(ArithmeticDecimalNullableProjection value)
        : this(
            (OneOf<
                FieldAsDecimalNullable,
                ParamAsDecimalNullable,
                LiteralAsDecimalNullable,
                ArithmeticDecimalNullableProjection,
                RoundingDecimalNullableProjection,
                DifferenceDecimalNullableProjection,
                ConditionalDecimalNullableProjection,
                AggregateDecimalNullableProjection
            >)
                value
        )
    { }

    public DecimalNullableProjection(RoundingDecimalNullableProjection value)
        : this(
            (OneOf<
                FieldAsDecimalNullable,
                ParamAsDecimalNullable,
                LiteralAsDecimalNullable,
                ArithmeticDecimalNullableProjection,
                RoundingDecimalNullableProjection,
                DifferenceDecimalNullableProjection,
                ConditionalDecimalNullableProjection,
                AggregateDecimalNullableProjection
            >)
                value
        )
    { }

    public DecimalNullableProjection(DifferenceDecimalNullableProjection value)
        : this(
            (OneOf<
                FieldAsDecimalNullable,
                ParamAsDecimalNullable,
                LiteralAsDecimalNullable,
                ArithmeticDecimalNullableProjection,
                RoundingDecimalNullableProjection,
                DifferenceDecimalNullableProjection,
                ConditionalDecimalNullableProjection,
                AggregateDecimalNullableProjection
            >)
                value
        )
    { }

    public DecimalNullableProjection(ConditionalDecimalNullableProjection value)
        : this(
            (OneOf<
                FieldAsDecimalNullable,
                ParamAsDecimalNullable,
                LiteralAsDecimalNullable,
                ArithmeticDecimalNullableProjection,
                RoundingDecimalNullableProjection,
                DifferenceDecimalNullableProjection,
                ConditionalDecimalNullableProjection,
                AggregateDecimalNullableProjection
            >)
                value
        )
    { }

    public DecimalNullableProjection(AggregateDecimalNullableProjection value)
        : this(
            (OneOf<
                FieldAsDecimalNullable,
                ParamAsDecimalNullable,
                LiteralAsDecimalNullable,
                ArithmeticDecimalNullableProjection,
                RoundingDecimalNullableProjection,
                DifferenceDecimalNullableProjection,
                ConditionalDecimalNullableProjection,
                AggregateDecimalNullableProjection
            >)
                value
        )
    { }

    private DecimalNullableProjection(
        OneOf<
            FieldAsDecimalNullable,
            ParamAsDecimalNullable,
            LiteralAsDecimalNullable,
            ArithmeticDecimalNullableProjection,
            RoundingDecimalNullableProjection,
            DifferenceDecimalNullableProjection,
            ConditionalDecimalNullableProjection,
            AggregateDecimalNullableProjection
        > input
    )
        : base(input) { }
}
