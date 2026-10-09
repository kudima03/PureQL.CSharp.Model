using OneOf;
using PureQL.CSharp.Model.Fields;
using PureQL.CSharp.Model.Literals;
using PureQL.CSharp.Model.Parameters;

namespace PureQL.CSharp.Model.RowExpressions;

public sealed class DecimalRow
    : OneOfBase<
        FieldAsDecimal,
        ParamAsDecimal,
        LiteralAsDecimal,
        ArithmeticDecimalRow,
        RoundingDecimalRow,
        DifferenceDecimalRow,
        ConditionalDecimalRow
    >
{
    public DecimalRow(FieldAsDecimal value)
        : this(
            (OneOf<
                FieldAsDecimal,
                ParamAsDecimal,
                LiteralAsDecimal,
                ArithmeticDecimalRow,
                RoundingDecimalRow,
                DifferenceDecimalRow,
                ConditionalDecimalRow
            >)
                value
        )
    { }

    public DecimalRow(ParamAsDecimal value)
        : this(
            (OneOf<
                FieldAsDecimal,
                ParamAsDecimal,
                LiteralAsDecimal,
                ArithmeticDecimalRow,
                RoundingDecimalRow,
                DifferenceDecimalRow,
                ConditionalDecimalRow
            >)
                value
        )
    { }

    public DecimalRow(LiteralAsDecimal value)
        : this(
            (OneOf<
                FieldAsDecimal,
                ParamAsDecimal,
                LiteralAsDecimal,
                ArithmeticDecimalRow,
                RoundingDecimalRow,
                DifferenceDecimalRow,
                ConditionalDecimalRow
            >)
                value
        )
    { }

    public DecimalRow(ArithmeticDecimalRow value)
        : this(
            (OneOf<
                FieldAsDecimal,
                ParamAsDecimal,
                LiteralAsDecimal,
                ArithmeticDecimalRow,
                RoundingDecimalRow,
                DifferenceDecimalRow,
                ConditionalDecimalRow
            >)
                value
        )
    { }

    public DecimalRow(RoundingDecimalRow value)
        : this(
            (OneOf<
                FieldAsDecimal,
                ParamAsDecimal,
                LiteralAsDecimal,
                ArithmeticDecimalRow,
                RoundingDecimalRow,
                DifferenceDecimalRow,
                ConditionalDecimalRow
            >)
                value
        )
    { }

    public DecimalRow(DifferenceDecimalRow value)
        : this(
            (OneOf<
                FieldAsDecimal,
                ParamAsDecimal,
                LiteralAsDecimal,
                ArithmeticDecimalRow,
                RoundingDecimalRow,
                DifferenceDecimalRow,
                ConditionalDecimalRow
            >)
                value
        )
    { }

    public DecimalRow(ConditionalDecimalRow value)
        : this(
            (OneOf<
                FieldAsDecimal,
                ParamAsDecimal,
                LiteralAsDecimal,
                ArithmeticDecimalRow,
                RoundingDecimalRow,
                DifferenceDecimalRow,
                ConditionalDecimalRow
            >)
                value
        )
    { }

    private DecimalRow(
        OneOf<
            FieldAsDecimal,
            ParamAsDecimal,
            LiteralAsDecimal,
            ArithmeticDecimalRow,
            RoundingDecimalRow,
            DifferenceDecimalRow,
            ConditionalDecimalRow
        > input
    )
        : base(input) { }
}
