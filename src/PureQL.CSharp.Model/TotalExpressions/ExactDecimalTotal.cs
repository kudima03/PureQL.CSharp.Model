using OneOf;
using PureQL.CSharp.Model.Literals;
using PureQL.CSharp.Model.Parameters;

namespace PureQL.CSharp.Model.TotalExpressions;

public sealed class ExactDecimalTotal
    : OneOfBase<
        ParamDecimal,
        LiteralDecimal,
        ArithmeticDecimalTotal,
        RoundDecimalTotal,
        DifferenceDecimalTotal,
        ConditionalDecimalTotal,
        SumDecimalTotal
    >
{
    public ExactDecimalTotal(ParamDecimal value)
        : this(
            (OneOf<
                ParamDecimal,
                LiteralDecimal,
                ArithmeticDecimalTotal,
                RoundDecimalTotal,
                DifferenceDecimalTotal,
                ConditionalDecimalTotal,
                SumDecimalTotal
            >)
                value
        )
    { }

    public ExactDecimalTotal(LiteralDecimal value)
        : this(
            (OneOf<
                ParamDecimal,
                LiteralDecimal,
                ArithmeticDecimalTotal,
                RoundDecimalTotal,
                DifferenceDecimalTotal,
                ConditionalDecimalTotal,
                SumDecimalTotal
            >)
                value
        )
    { }

    public ExactDecimalTotal(ArithmeticDecimalTotal value)
        : this(
            (OneOf<
                ParamDecimal,
                LiteralDecimal,
                ArithmeticDecimalTotal,
                RoundDecimalTotal,
                DifferenceDecimalTotal,
                ConditionalDecimalTotal,
                SumDecimalTotal
            >)
                value
        )
    { }

    public ExactDecimalTotal(RoundDecimalTotal value)
        : this(
            (OneOf<
                ParamDecimal,
                LiteralDecimal,
                ArithmeticDecimalTotal,
                RoundDecimalTotal,
                DifferenceDecimalTotal,
                ConditionalDecimalTotal,
                SumDecimalTotal
            >)
                value
        )
    { }

    public ExactDecimalTotal(DifferenceDecimalTotal value)
        : this(
            (OneOf<
                ParamDecimal,
                LiteralDecimal,
                ArithmeticDecimalTotal,
                RoundDecimalTotal,
                DifferenceDecimalTotal,
                ConditionalDecimalTotal,
                SumDecimalTotal
            >)
                value
        )
    { }

    public ExactDecimalTotal(ConditionalDecimalTotal value)
        : this(
            (OneOf<
                ParamDecimal,
                LiteralDecimal,
                ArithmeticDecimalTotal,
                RoundDecimalTotal,
                DifferenceDecimalTotal,
                ConditionalDecimalTotal,
                SumDecimalTotal
            >)
                value
        )
    { }

    public ExactDecimalTotal(SumDecimalTotal value)
        : this(
            (OneOf<
                ParamDecimal,
                LiteralDecimal,
                ArithmeticDecimalTotal,
                RoundDecimalTotal,
                DifferenceDecimalTotal,
                ConditionalDecimalTotal,
                SumDecimalTotal
            >)
                value
        )
    { }

    private ExactDecimalTotal(
        OneOf<
            ParamDecimal,
            LiteralDecimal,
            ArithmeticDecimalTotal,
            RoundDecimalTotal,
            DifferenceDecimalTotal,
            ConditionalDecimalTotal,
            SumDecimalTotal
        > input
    )
        : base(input) { }
}
