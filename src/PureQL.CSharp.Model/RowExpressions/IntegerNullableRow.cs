using OneOf;
using PureQL.CSharp.Model.Fields;
using PureQL.CSharp.Model.Literals;
using PureQL.CSharp.Model.Parameters;

namespace PureQL.CSharp.Model.RowExpressions;

public sealed class IntegerNullableRow
    : OneOfBase<
        FieldAsIntegerNullable,
        ParamAsIntegerNullable,
        LiteralAsIntegerNullable,
        ArithmeticIntegerNullableRow,
        RoundingIntegerNullableRow,
        DateDiffDaysIntegerNullableRow,
        ConditionalIntegerNullableRow
    >
{
    public IntegerNullableRow(FieldAsIntegerNullable value)
        : this(
            (OneOf<
                FieldAsIntegerNullable,
                ParamAsIntegerNullable,
                LiteralAsIntegerNullable,
                ArithmeticIntegerNullableRow,
                RoundingIntegerNullableRow,
                DateDiffDaysIntegerNullableRow,
                ConditionalIntegerNullableRow
            >)
                value
        )
    { }

    public IntegerNullableRow(ParamAsIntegerNullable value)
        : this(
            (OneOf<
                FieldAsIntegerNullable,
                ParamAsIntegerNullable,
                LiteralAsIntegerNullable,
                ArithmeticIntegerNullableRow,
                RoundingIntegerNullableRow,
                DateDiffDaysIntegerNullableRow,
                ConditionalIntegerNullableRow
            >)
                value
        )
    { }

    public IntegerNullableRow(LiteralAsIntegerNullable value)
        : this(
            (OneOf<
                FieldAsIntegerNullable,
                ParamAsIntegerNullable,
                LiteralAsIntegerNullable,
                ArithmeticIntegerNullableRow,
                RoundingIntegerNullableRow,
                DateDiffDaysIntegerNullableRow,
                ConditionalIntegerNullableRow
            >)
                value
        )
    { }

    public IntegerNullableRow(ArithmeticIntegerNullableRow value)
        : this(
            (OneOf<
                FieldAsIntegerNullable,
                ParamAsIntegerNullable,
                LiteralAsIntegerNullable,
                ArithmeticIntegerNullableRow,
                RoundingIntegerNullableRow,
                DateDiffDaysIntegerNullableRow,
                ConditionalIntegerNullableRow
            >)
                value
        )
    { }

    public IntegerNullableRow(RoundingIntegerNullableRow value)
        : this(
            (OneOf<
                FieldAsIntegerNullable,
                ParamAsIntegerNullable,
                LiteralAsIntegerNullable,
                ArithmeticIntegerNullableRow,
                RoundingIntegerNullableRow,
                DateDiffDaysIntegerNullableRow,
                ConditionalIntegerNullableRow
            >)
                value
        )
    { }

    public IntegerNullableRow(DateDiffDaysIntegerNullableRow value)
        : this(
            (OneOf<
                FieldAsIntegerNullable,
                ParamAsIntegerNullable,
                LiteralAsIntegerNullable,
                ArithmeticIntegerNullableRow,
                RoundingIntegerNullableRow,
                DateDiffDaysIntegerNullableRow,
                ConditionalIntegerNullableRow
            >)
                value
        )
    { }

    public IntegerNullableRow(ConditionalIntegerNullableRow value)
        : this(
            (OneOf<
                FieldAsIntegerNullable,
                ParamAsIntegerNullable,
                LiteralAsIntegerNullable,
                ArithmeticIntegerNullableRow,
                RoundingIntegerNullableRow,
                DateDiffDaysIntegerNullableRow,
                ConditionalIntegerNullableRow
            >)
                value
        )
    { }

    private IntegerNullableRow(
        OneOf<
            FieldAsIntegerNullable,
            ParamAsIntegerNullable,
            LiteralAsIntegerNullable,
            ArithmeticIntegerNullableRow,
            RoundingIntegerNullableRow,
            DateDiffDaysIntegerNullableRow,
            ConditionalIntegerNullableRow
        > input
    )
        : base(input) { }
}
