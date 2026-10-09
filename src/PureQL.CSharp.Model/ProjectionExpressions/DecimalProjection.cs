using OneOf;
using PureQL.CSharp.Model.Fields;
using PureQL.CSharp.Model.Literals;
using PureQL.CSharp.Model.Parameters;

namespace PureQL.CSharp.Model.ProjectionExpressions;

public sealed class DecimalProjection
    : OneOfBase<
        FieldAsDecimal,
        ParamAsDecimal,
        LiteralAsDecimal,
        ArithmeticDecimalProjection,
        RoundingDecimalProjection,
        DifferenceDecimalProjection,
        ConditionalDecimalProjection,
        AggregateDecimalProjection
    >
{
    public DecimalProjection(FieldAsDecimal value)
        : this(
            (OneOf<
                FieldAsDecimal,
                ParamAsDecimal,
                LiteralAsDecimal,
                ArithmeticDecimalProjection,
                RoundingDecimalProjection,
                DifferenceDecimalProjection,
                ConditionalDecimalProjection,
                AggregateDecimalProjection
            >)
                value
        )
    { }

    public DecimalProjection(ParamAsDecimal value)
        : this(
            (OneOf<
                FieldAsDecimal,
                ParamAsDecimal,
                LiteralAsDecimal,
                ArithmeticDecimalProjection,
                RoundingDecimalProjection,
                DifferenceDecimalProjection,
                ConditionalDecimalProjection,
                AggregateDecimalProjection
            >)
                value
        )
    { }

    public DecimalProjection(LiteralAsDecimal value)
        : this(
            (OneOf<
                FieldAsDecimal,
                ParamAsDecimal,
                LiteralAsDecimal,
                ArithmeticDecimalProjection,
                RoundingDecimalProjection,
                DifferenceDecimalProjection,
                ConditionalDecimalProjection,
                AggregateDecimalProjection
            >)
                value
        )
    { }

    public DecimalProjection(ArithmeticDecimalProjection value)
        : this(
            (OneOf<
                FieldAsDecimal,
                ParamAsDecimal,
                LiteralAsDecimal,
                ArithmeticDecimalProjection,
                RoundingDecimalProjection,
                DifferenceDecimalProjection,
                ConditionalDecimalProjection,
                AggregateDecimalProjection
            >)
                value
        )
    { }

    public DecimalProjection(RoundingDecimalProjection value)
        : this(
            (OneOf<
                FieldAsDecimal,
                ParamAsDecimal,
                LiteralAsDecimal,
                ArithmeticDecimalProjection,
                RoundingDecimalProjection,
                DifferenceDecimalProjection,
                ConditionalDecimalProjection,
                AggregateDecimalProjection
            >)
                value
        )
    { }

    public DecimalProjection(DifferenceDecimalProjection value)
        : this(
            (OneOf<
                FieldAsDecimal,
                ParamAsDecimal,
                LiteralAsDecimal,
                ArithmeticDecimalProjection,
                RoundingDecimalProjection,
                DifferenceDecimalProjection,
                ConditionalDecimalProjection,
                AggregateDecimalProjection
            >)
                value
        )
    { }

    public DecimalProjection(ConditionalDecimalProjection value)
        : this(
            (OneOf<
                FieldAsDecimal,
                ParamAsDecimal,
                LiteralAsDecimal,
                ArithmeticDecimalProjection,
                RoundingDecimalProjection,
                DifferenceDecimalProjection,
                ConditionalDecimalProjection,
                AggregateDecimalProjection
            >)
                value
        )
    { }

    public DecimalProjection(AggregateDecimalProjection value)
        : this(
            (OneOf<
                FieldAsDecimal,
                ParamAsDecimal,
                LiteralAsDecimal,
                ArithmeticDecimalProjection,
                RoundingDecimalProjection,
                DifferenceDecimalProjection,
                ConditionalDecimalProjection,
                AggregateDecimalProjection
            >)
                value
        )
    { }

    private DecimalProjection(
        OneOf<
            FieldAsDecimal,
            ParamAsDecimal,
            LiteralAsDecimal,
            ArithmeticDecimalProjection,
            RoundingDecimalProjection,
            DifferenceDecimalProjection,
            ConditionalDecimalProjection,
            AggregateDecimalProjection
        > input
    )
        : base(input) { }
}
