using OneOf;
using PureQL.CSharp.Model.Fields;
using PureQL.CSharp.Model.Literals;
using PureQL.CSharp.Model.Parameters;

namespace PureQL.CSharp.Model.RowExpressions;

public sealed class ExactDecimalRow
    : OneOfBase<
        FieldDecimal,
        ParamDecimal,
        LiteralDecimal,
        ArithmeticDecimalRow,
        RoundDecimalRow,
        DifferenceDecimalRow,
        ConditionalDecimalRow
    >
{
    public ExactDecimalRow(FieldDecimal value)
        : this(
            (OneOf<
                FieldDecimal,
                ParamDecimal,
                LiteralDecimal,
                ArithmeticDecimalRow,
                RoundDecimalRow,
                DifferenceDecimalRow,
                ConditionalDecimalRow
            >)
                value
        )
    { }

    public ExactDecimalRow(ParamDecimal value)
        : this(
            (OneOf<
                FieldDecimal,
                ParamDecimal,
                LiteralDecimal,
                ArithmeticDecimalRow,
                RoundDecimalRow,
                DifferenceDecimalRow,
                ConditionalDecimalRow
            >)
                value
        )
    { }

    public ExactDecimalRow(LiteralDecimal value)
        : this(
            (OneOf<
                FieldDecimal,
                ParamDecimal,
                LiteralDecimal,
                ArithmeticDecimalRow,
                RoundDecimalRow,
                DifferenceDecimalRow,
                ConditionalDecimalRow
            >)
                value
        )
    { }

    public ExactDecimalRow(ArithmeticDecimalRow value)
        : this(
            (OneOf<
                FieldDecimal,
                ParamDecimal,
                LiteralDecimal,
                ArithmeticDecimalRow,
                RoundDecimalRow,
                DifferenceDecimalRow,
                ConditionalDecimalRow
            >)
                value
        )
    { }

    public ExactDecimalRow(RoundDecimalRow value)
        : this(
            (OneOf<
                FieldDecimal,
                ParamDecimal,
                LiteralDecimal,
                ArithmeticDecimalRow,
                RoundDecimalRow,
                DifferenceDecimalRow,
                ConditionalDecimalRow
            >)
                value
        )
    { }

    public ExactDecimalRow(DifferenceDecimalRow value)
        : this(
            (OneOf<
                FieldDecimal,
                ParamDecimal,
                LiteralDecimal,
                ArithmeticDecimalRow,
                RoundDecimalRow,
                DifferenceDecimalRow,
                ConditionalDecimalRow
            >)
                value
        )
    { }

    public ExactDecimalRow(ConditionalDecimalRow value)
        : this(
            (OneOf<
                FieldDecimal,
                ParamDecimal,
                LiteralDecimal,
                ArithmeticDecimalRow,
                RoundDecimalRow,
                DifferenceDecimalRow,
                ConditionalDecimalRow
            >)
                value
        )
    { }

    private ExactDecimalRow(
        OneOf<
            FieldDecimal,
            ParamDecimal,
            LiteralDecimal,
            ArithmeticDecimalRow,
            RoundDecimalRow,
            DifferenceDecimalRow,
            ConditionalDecimalRow
        > input
    )
        : base(input) { }
}
