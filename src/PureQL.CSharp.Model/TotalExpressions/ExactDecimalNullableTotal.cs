using OneOf;
using PureQL.CSharp.Model.Literals;
using PureQL.CSharp.Model.Parameters;

namespace PureQL.CSharp.Model.TotalExpressions;

public sealed class ExactDecimalNullableTotal
    : OneOfBase<
        ParamDecimalNullable,
        LiteralDecimalNullable,
        ArithmeticDecimalNullableTotal,
        RoundDecimalNullableTotal,
        DifferenceDecimalNullableTotal,
        ConditionalDecimalNullableTotal,
        AggregateDecimalNullableTotal
    >
{
    public ExactDecimalNullableTotal(ParamDecimalNullable value)
        : this(
            (OneOf<
                ParamDecimalNullable,
                LiteralDecimalNullable,
                ArithmeticDecimalNullableTotal,
                RoundDecimalNullableTotal,
                DifferenceDecimalNullableTotal,
                ConditionalDecimalNullableTotal,
                AggregateDecimalNullableTotal
            >)
                value
        )
    { }

    public ExactDecimalNullableTotal(LiteralDecimalNullable value)
        : this(
            (OneOf<
                ParamDecimalNullable,
                LiteralDecimalNullable,
                ArithmeticDecimalNullableTotal,
                RoundDecimalNullableTotal,
                DifferenceDecimalNullableTotal,
                ConditionalDecimalNullableTotal,
                AggregateDecimalNullableTotal
            >)
                value
        )
    { }

    public ExactDecimalNullableTotal(ArithmeticDecimalNullableTotal value)
        : this(
            (OneOf<
                ParamDecimalNullable,
                LiteralDecimalNullable,
                ArithmeticDecimalNullableTotal,
                RoundDecimalNullableTotal,
                DifferenceDecimalNullableTotal,
                ConditionalDecimalNullableTotal,
                AggregateDecimalNullableTotal
            >)
                value
        )
    { }

    public ExactDecimalNullableTotal(RoundDecimalNullableTotal value)
        : this(
            (OneOf<
                ParamDecimalNullable,
                LiteralDecimalNullable,
                ArithmeticDecimalNullableTotal,
                RoundDecimalNullableTotal,
                DifferenceDecimalNullableTotal,
                ConditionalDecimalNullableTotal,
                AggregateDecimalNullableTotal
            >)
                value
        )
    { }

    public ExactDecimalNullableTotal(DifferenceDecimalNullableTotal value)
        : this(
            (OneOf<
                ParamDecimalNullable,
                LiteralDecimalNullable,
                ArithmeticDecimalNullableTotal,
                RoundDecimalNullableTotal,
                DifferenceDecimalNullableTotal,
                ConditionalDecimalNullableTotal,
                AggregateDecimalNullableTotal
            >)
                value
        )
    { }

    public ExactDecimalNullableTotal(ConditionalDecimalNullableTotal value)
        : this(
            (OneOf<
                ParamDecimalNullable,
                LiteralDecimalNullable,
                ArithmeticDecimalNullableTotal,
                RoundDecimalNullableTotal,
                DifferenceDecimalNullableTotal,
                ConditionalDecimalNullableTotal,
                AggregateDecimalNullableTotal
            >)
                value
        )
    { }

    public ExactDecimalNullableTotal(AggregateDecimalNullableTotal value)
        : this(
            (OneOf<
                ParamDecimalNullable,
                LiteralDecimalNullable,
                ArithmeticDecimalNullableTotal,
                RoundDecimalNullableTotal,
                DifferenceDecimalNullableTotal,
                ConditionalDecimalNullableTotal,
                AggregateDecimalNullableTotal
            >)
                value
        )
    { }

    private ExactDecimalNullableTotal(
        OneOf<
            ParamDecimalNullable,
            LiteralDecimalNullable,
            ArithmeticDecimalNullableTotal,
            RoundDecimalNullableTotal,
            DifferenceDecimalNullableTotal,
            ConditionalDecimalNullableTotal,
            AggregateDecimalNullableTotal
        > input
    )
        : base(input) { }
}
