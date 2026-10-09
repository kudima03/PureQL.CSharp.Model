using OneOf;
using PureQL.CSharp.Model.Fields;
using PureQL.CSharp.Model.Literals;
using PureQL.CSharp.Model.Parameters;

namespace PureQL.CSharp.Model.RowExpressions;

public sealed class IntegerRow
    : OneOfBase<
        FieldInteger,
        ParamInteger,
        LiteralInteger,
        ArithmeticIntegerRow,
        RoundingIntegerRow,
        DateDiffDaysIntegerRow,
        ConditionalIntegerRow
    >
{
    public IntegerRow(FieldInteger value)
        : this(
            (OneOf<
                FieldInteger,
                ParamInteger,
                LiteralInteger,
                ArithmeticIntegerRow,
                RoundingIntegerRow,
                DateDiffDaysIntegerRow,
                ConditionalIntegerRow
            >)
                value
        )
    { }

    public IntegerRow(ParamInteger value)
        : this(
            (OneOf<
                FieldInteger,
                ParamInteger,
                LiteralInteger,
                ArithmeticIntegerRow,
                RoundingIntegerRow,
                DateDiffDaysIntegerRow,
                ConditionalIntegerRow
            >)
                value
        )
    { }

    public IntegerRow(LiteralInteger value)
        : this(
            (OneOf<
                FieldInteger,
                ParamInteger,
                LiteralInteger,
                ArithmeticIntegerRow,
                RoundingIntegerRow,
                DateDiffDaysIntegerRow,
                ConditionalIntegerRow
            >)
                value
        )
    { }

    public IntegerRow(ArithmeticIntegerRow value)
        : this(
            (OneOf<
                FieldInteger,
                ParamInteger,
                LiteralInteger,
                ArithmeticIntegerRow,
                RoundingIntegerRow,
                DateDiffDaysIntegerRow,
                ConditionalIntegerRow
            >)
                value
        )
    { }

    public IntegerRow(RoundingIntegerRow value)
        : this(
            (OneOf<
                FieldInteger,
                ParamInteger,
                LiteralInteger,
                ArithmeticIntegerRow,
                RoundingIntegerRow,
                DateDiffDaysIntegerRow,
                ConditionalIntegerRow
            >)
                value
        )
    { }

    public IntegerRow(DateDiffDaysIntegerRow value)
        : this(
            (OneOf<
                FieldInteger,
                ParamInteger,
                LiteralInteger,
                ArithmeticIntegerRow,
                RoundingIntegerRow,
                DateDiffDaysIntegerRow,
                ConditionalIntegerRow
            >)
                value
        )
    { }

    public IntegerRow(ConditionalIntegerRow value)
        : this(
            (OneOf<
                FieldInteger,
                ParamInteger,
                LiteralInteger,
                ArithmeticIntegerRow,
                RoundingIntegerRow,
                DateDiffDaysIntegerRow,
                ConditionalIntegerRow
            >)
                value
        )
    { }

    private IntegerRow(
        OneOf<
            FieldInteger,
            ParamInteger,
            LiteralInteger,
            ArithmeticIntegerRow,
            RoundingIntegerRow,
            DateDiffDaysIntegerRow,
            ConditionalIntegerRow
        > input
    )
        : base(input) { }
}
