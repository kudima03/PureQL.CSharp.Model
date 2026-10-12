using OneOf;
using PureQL.CSharp.Model.Fields;
using PureQL.CSharp.Model.Literals;
using PureQL.CSharp.Model.Parameters;

namespace PureQL.CSharp.Model.ProjectionExpressions;

public sealed class ExactDecimalProjection
    : OneOfBase<
        FieldDecimal,
        ParamDecimal,
        LiteralDecimal,
        ArithmeticDecimalProjection,
        RoundDecimalProjection,
        DifferenceDecimalProjection,
        ConditionalDecimalProjection,
        AggregateDecimalProjection
    >
{
    public ExactDecimalProjection(FieldDecimal value)
        : this(
            (OneOf<
                FieldDecimal,
                ParamDecimal,
                LiteralDecimal,
                ArithmeticDecimalProjection,
                RoundDecimalProjection,
                DifferenceDecimalProjection,
                ConditionalDecimalProjection,
                AggregateDecimalProjection
            >)
                value
        )
    { }

    public ExactDecimalProjection(ParamDecimal value)
        : this(
            (OneOf<
                FieldDecimal,
                ParamDecimal,
                LiteralDecimal,
                ArithmeticDecimalProjection,
                RoundDecimalProjection,
                DifferenceDecimalProjection,
                ConditionalDecimalProjection,
                AggregateDecimalProjection
            >)
                value
        )
    { }

    public ExactDecimalProjection(LiteralDecimal value)
        : this(
            (OneOf<
                FieldDecimal,
                ParamDecimal,
                LiteralDecimal,
                ArithmeticDecimalProjection,
                RoundDecimalProjection,
                DifferenceDecimalProjection,
                ConditionalDecimalProjection,
                AggregateDecimalProjection
            >)
                value
        )
    { }

    public ExactDecimalProjection(ArithmeticDecimalProjection value)
        : this(
            (OneOf<
                FieldDecimal,
                ParamDecimal,
                LiteralDecimal,
                ArithmeticDecimalProjection,
                RoundDecimalProjection,
                DifferenceDecimalProjection,
                ConditionalDecimalProjection,
                AggregateDecimalProjection
            >)
                value
        )
    { }

    public ExactDecimalProjection(RoundDecimalProjection value)
        : this(
            (OneOf<
                FieldDecimal,
                ParamDecimal,
                LiteralDecimal,
                ArithmeticDecimalProjection,
                RoundDecimalProjection,
                DifferenceDecimalProjection,
                ConditionalDecimalProjection,
                AggregateDecimalProjection
            >)
                value
        )
    { }

    public ExactDecimalProjection(DifferenceDecimalProjection value)
        : this(
            (OneOf<
                FieldDecimal,
                ParamDecimal,
                LiteralDecimal,
                ArithmeticDecimalProjection,
                RoundDecimalProjection,
                DifferenceDecimalProjection,
                ConditionalDecimalProjection,
                AggregateDecimalProjection
            >)
                value
        )
    { }

    public ExactDecimalProjection(ConditionalDecimalProjection value)
        : this(
            (OneOf<
                FieldDecimal,
                ParamDecimal,
                LiteralDecimal,
                ArithmeticDecimalProjection,
                RoundDecimalProjection,
                DifferenceDecimalProjection,
                ConditionalDecimalProjection,
                AggregateDecimalProjection
            >)
                value
        )
    { }

    public ExactDecimalProjection(AggregateDecimalProjection value)
        : this(
            (OneOf<
                FieldDecimal,
                ParamDecimal,
                LiteralDecimal,
                ArithmeticDecimalProjection,
                RoundDecimalProjection,
                DifferenceDecimalProjection,
                ConditionalDecimalProjection,
                AggregateDecimalProjection
            >)
                value
        )
    { }

    private ExactDecimalProjection(
        OneOf<
            FieldDecimal,
            ParamDecimal,
            LiteralDecimal,
            ArithmeticDecimalProjection,
            RoundDecimalProjection,
            DifferenceDecimalProjection,
            ConditionalDecimalProjection,
            AggregateDecimalProjection
        > input
    )
        : base(input) { }
}
