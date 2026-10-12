using OneOf;
using PureQL.CSharp.Model.Fields;
using PureQL.CSharp.Model.Literals;
using PureQL.CSharp.Model.Parameters;

namespace PureQL.CSharp.Model.RowExpressions;

public sealed class ExactIntegerNullableRow
    : OneOfBase<
        FieldIntegerNullable,
        ParamIntegerNullable,
        LiteralIntegerNullable,
        ArithmeticIntegerNullableRow,
        RoundingIntegerNullableRow,
        DateDiffDaysIntegerNullableRow,
        ConditionalIntegerNullableRow
    >
{
    public ExactIntegerNullableRow(FieldIntegerNullable value)
        : this(
            (OneOf<
                FieldIntegerNullable,
                ParamIntegerNullable,
                LiteralIntegerNullable,
                ArithmeticIntegerNullableRow,
                RoundingIntegerNullableRow,
                DateDiffDaysIntegerNullableRow,
                ConditionalIntegerNullableRow
            >)
                value
        )
    { }

    public ExactIntegerNullableRow(ParamIntegerNullable value)
        : this(
            (OneOf<
                FieldIntegerNullable,
                ParamIntegerNullable,
                LiteralIntegerNullable,
                ArithmeticIntegerNullableRow,
                RoundingIntegerNullableRow,
                DateDiffDaysIntegerNullableRow,
                ConditionalIntegerNullableRow
            >)
                value
        )
    { }

    public ExactIntegerNullableRow(LiteralIntegerNullable value)
        : this(
            (OneOf<
                FieldIntegerNullable,
                ParamIntegerNullable,
                LiteralIntegerNullable,
                ArithmeticIntegerNullableRow,
                RoundingIntegerNullableRow,
                DateDiffDaysIntegerNullableRow,
                ConditionalIntegerNullableRow
            >)
                value
        )
    { }

    public ExactIntegerNullableRow(ArithmeticIntegerNullableRow value)
        : this(
            (OneOf<
                FieldIntegerNullable,
                ParamIntegerNullable,
                LiteralIntegerNullable,
                ArithmeticIntegerNullableRow,
                RoundingIntegerNullableRow,
                DateDiffDaysIntegerNullableRow,
                ConditionalIntegerNullableRow
            >)
                value
        )
    { }

    public ExactIntegerNullableRow(RoundingIntegerNullableRow value)
        : this(
            (OneOf<
                FieldIntegerNullable,
                ParamIntegerNullable,
                LiteralIntegerNullable,
                ArithmeticIntegerNullableRow,
                RoundingIntegerNullableRow,
                DateDiffDaysIntegerNullableRow,
                ConditionalIntegerNullableRow
            >)
                value
        )
    { }

    public ExactIntegerNullableRow(DateDiffDaysIntegerNullableRow value)
        : this(
            (OneOf<
                FieldIntegerNullable,
                ParamIntegerNullable,
                LiteralIntegerNullable,
                ArithmeticIntegerNullableRow,
                RoundingIntegerNullableRow,
                DateDiffDaysIntegerNullableRow,
                ConditionalIntegerNullableRow
            >)
                value
        )
    { }

    public ExactIntegerNullableRow(ConditionalIntegerNullableRow value)
        : this(
            (OneOf<
                FieldIntegerNullable,
                ParamIntegerNullable,
                LiteralIntegerNullable,
                ArithmeticIntegerNullableRow,
                RoundingIntegerNullableRow,
                DateDiffDaysIntegerNullableRow,
                ConditionalIntegerNullableRow
            >)
                value
        )
    { }

    private ExactIntegerNullableRow(
        OneOf<
            FieldIntegerNullable,
            ParamIntegerNullable,
            LiteralIntegerNullable,
            ArithmeticIntegerNullableRow,
            RoundingIntegerNullableRow,
            DateDiffDaysIntegerNullableRow,
            ConditionalIntegerNullableRow
        > input
    )
        : base(input) { }
}
