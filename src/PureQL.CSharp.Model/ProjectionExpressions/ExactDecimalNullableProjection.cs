using OneOf;
using PureQL.CSharp.Model.Fields;
using PureQL.CSharp.Model.Literals;
using PureQL.CSharp.Model.Parameters;

namespace PureQL.CSharp.Model.ProjectionExpressions;

public sealed class ExactDecimalNullableProjection
    : OneOfBase<
        FieldDecimalNullable,
        ParamDecimalNullable,
        LiteralDecimalNullable,
        ArithmeticDecimalNullableProjection,
        RoundDecimalNullableProjection,
        DifferenceDecimalNullableProjection,
        ConditionalDecimalNullableProjection,
        AggregateDecimalNullableProjection
    >
{
    public ExactDecimalNullableProjection(FieldDecimalNullable value)
        : this(
            (OneOf<
                FieldDecimalNullable,
                ParamDecimalNullable,
                LiteralDecimalNullable,
                ArithmeticDecimalNullableProjection,
                RoundDecimalNullableProjection,
                DifferenceDecimalNullableProjection,
                ConditionalDecimalNullableProjection,
                AggregateDecimalNullableProjection
            >)
                value
        )
    { }

    public ExactDecimalNullableProjection(ParamDecimalNullable value)
        : this(
            (OneOf<
                FieldDecimalNullable,
                ParamDecimalNullable,
                LiteralDecimalNullable,
                ArithmeticDecimalNullableProjection,
                RoundDecimalNullableProjection,
                DifferenceDecimalNullableProjection,
                ConditionalDecimalNullableProjection,
                AggregateDecimalNullableProjection
            >)
                value
        )
    { }

    public ExactDecimalNullableProjection(LiteralDecimalNullable value)
        : this(
            (OneOf<
                FieldDecimalNullable,
                ParamDecimalNullable,
                LiteralDecimalNullable,
                ArithmeticDecimalNullableProjection,
                RoundDecimalNullableProjection,
                DifferenceDecimalNullableProjection,
                ConditionalDecimalNullableProjection,
                AggregateDecimalNullableProjection
            >)
                value
        )
    { }

    public ExactDecimalNullableProjection(ArithmeticDecimalNullableProjection value)
        : this(
            (OneOf<
                FieldDecimalNullable,
                ParamDecimalNullable,
                LiteralDecimalNullable,
                ArithmeticDecimalNullableProjection,
                RoundDecimalNullableProjection,
                DifferenceDecimalNullableProjection,
                ConditionalDecimalNullableProjection,
                AggregateDecimalNullableProjection
            >)
                value
        )
    { }

    public ExactDecimalNullableProjection(RoundDecimalNullableProjection value)
        : this(
            (OneOf<
                FieldDecimalNullable,
                ParamDecimalNullable,
                LiteralDecimalNullable,
                ArithmeticDecimalNullableProjection,
                RoundDecimalNullableProjection,
                DifferenceDecimalNullableProjection,
                ConditionalDecimalNullableProjection,
                AggregateDecimalNullableProjection
            >)
                value
        )
    { }

    public ExactDecimalNullableProjection(DifferenceDecimalNullableProjection value)
        : this(
            (OneOf<
                FieldDecimalNullable,
                ParamDecimalNullable,
                LiteralDecimalNullable,
                ArithmeticDecimalNullableProjection,
                RoundDecimalNullableProjection,
                DifferenceDecimalNullableProjection,
                ConditionalDecimalNullableProjection,
                AggregateDecimalNullableProjection
            >)
                value
        )
    { }

    public ExactDecimalNullableProjection(ConditionalDecimalNullableProjection value)
        : this(
            (OneOf<
                FieldDecimalNullable,
                ParamDecimalNullable,
                LiteralDecimalNullable,
                ArithmeticDecimalNullableProjection,
                RoundDecimalNullableProjection,
                DifferenceDecimalNullableProjection,
                ConditionalDecimalNullableProjection,
                AggregateDecimalNullableProjection
            >)
                value
        )
    { }

    public ExactDecimalNullableProjection(AggregateDecimalNullableProjection value)
        : this(
            (OneOf<
                FieldDecimalNullable,
                ParamDecimalNullable,
                LiteralDecimalNullable,
                ArithmeticDecimalNullableProjection,
                RoundDecimalNullableProjection,
                DifferenceDecimalNullableProjection,
                ConditionalDecimalNullableProjection,
                AggregateDecimalNullableProjection
            >)
                value
        )
    { }

    private ExactDecimalNullableProjection(
        OneOf<
            FieldDecimalNullable,
            ParamDecimalNullable,
            LiteralDecimalNullable,
            ArithmeticDecimalNullableProjection,
            RoundDecimalNullableProjection,
            DifferenceDecimalNullableProjection,
            ConditionalDecimalNullableProjection,
            AggregateDecimalNullableProjection
        > input
    )
        : base(input) { }
}
