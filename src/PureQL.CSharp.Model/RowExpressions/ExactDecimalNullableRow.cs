using OneOf;
using PureQL.CSharp.Model.Fields;
using PureQL.CSharp.Model.Literals;
using PureQL.CSharp.Model.Parameters;

namespace PureQL.CSharp.Model.RowExpressions;

public sealed class ExactDecimalNullableRow
    : OneOfBase<
        FieldDecimalNullable,
        ParamDecimalNullable,
        LiteralDecimalNullable,
        ArithmeticDecimalNullableRow,
        RoundDecimalNullableRow,
        DifferenceDecimalNullableRow,
        ConditionalDecimalNullableRow
    >
{
    public ExactDecimalNullableRow(FieldDecimalNullable value)
        : this(
            (OneOf<
                FieldDecimalNullable,
                ParamDecimalNullable,
                LiteralDecimalNullable,
                ArithmeticDecimalNullableRow,
                RoundDecimalNullableRow,
                DifferenceDecimalNullableRow,
                ConditionalDecimalNullableRow
            >)
                value
        )
    { }

    public ExactDecimalNullableRow(ParamDecimalNullable value)
        : this(
            (OneOf<
                FieldDecimalNullable,
                ParamDecimalNullable,
                LiteralDecimalNullable,
                ArithmeticDecimalNullableRow,
                RoundDecimalNullableRow,
                DifferenceDecimalNullableRow,
                ConditionalDecimalNullableRow
            >)
                value
        )
    { }

    public ExactDecimalNullableRow(LiteralDecimalNullable value)
        : this(
            (OneOf<
                FieldDecimalNullable,
                ParamDecimalNullable,
                LiteralDecimalNullable,
                ArithmeticDecimalNullableRow,
                RoundDecimalNullableRow,
                DifferenceDecimalNullableRow,
                ConditionalDecimalNullableRow
            >)
                value
        )
    { }

    public ExactDecimalNullableRow(ArithmeticDecimalNullableRow value)
        : this(
            (OneOf<
                FieldDecimalNullable,
                ParamDecimalNullable,
                LiteralDecimalNullable,
                ArithmeticDecimalNullableRow,
                RoundDecimalNullableRow,
                DifferenceDecimalNullableRow,
                ConditionalDecimalNullableRow
            >)
                value
        )
    { }

    public ExactDecimalNullableRow(RoundDecimalNullableRow value)
        : this(
            (OneOf<
                FieldDecimalNullable,
                ParamDecimalNullable,
                LiteralDecimalNullable,
                ArithmeticDecimalNullableRow,
                RoundDecimalNullableRow,
                DifferenceDecimalNullableRow,
                ConditionalDecimalNullableRow
            >)
                value
        )
    { }

    public ExactDecimalNullableRow(DifferenceDecimalNullableRow value)
        : this(
            (OneOf<
                FieldDecimalNullable,
                ParamDecimalNullable,
                LiteralDecimalNullable,
                ArithmeticDecimalNullableRow,
                RoundDecimalNullableRow,
                DifferenceDecimalNullableRow,
                ConditionalDecimalNullableRow
            >)
                value
        )
    { }

    public ExactDecimalNullableRow(ConditionalDecimalNullableRow value)
        : this(
            (OneOf<
                FieldDecimalNullable,
                ParamDecimalNullable,
                LiteralDecimalNullable,
                ArithmeticDecimalNullableRow,
                RoundDecimalNullableRow,
                DifferenceDecimalNullableRow,
                ConditionalDecimalNullableRow
            >)
                value
        )
    { }

    private ExactDecimalNullableRow(
        OneOf<
            FieldDecimalNullable,
            ParamDecimalNullable,
            LiteralDecimalNullable,
            ArithmeticDecimalNullableRow,
            RoundDecimalNullableRow,
            DifferenceDecimalNullableRow,
            ConditionalDecimalNullableRow
        > input
    )
        : base(input) { }
}
