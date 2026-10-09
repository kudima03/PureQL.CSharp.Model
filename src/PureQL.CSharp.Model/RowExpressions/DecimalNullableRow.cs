using OneOf;
using PureQL.CSharp.Model.Fields;
using PureQL.CSharp.Model.Literals;
using PureQL.CSharp.Model.Parameters;

namespace PureQL.CSharp.Model.RowExpressions;

public sealed class DecimalNullableRow
    : OneOfBase<
        FieldAsDecimalNullable,
        ParamAsDecimalNullable,
        LiteralAsDecimalNullable,
        ArithmeticDecimalNullableRow,
        RoundingDecimalNullableRow,
        DifferenceDecimalNullableRow,
        ConditionalDecimalNullableRow
    >
{
    public DecimalNullableRow(FieldAsDecimalNullable value)
        : this(
            (OneOf<
                FieldAsDecimalNullable,
                ParamAsDecimalNullable,
                LiteralAsDecimalNullable,
                ArithmeticDecimalNullableRow,
                RoundingDecimalNullableRow,
                DifferenceDecimalNullableRow,
                ConditionalDecimalNullableRow
            >)
                value
        )
    { }

    public DecimalNullableRow(ParamAsDecimalNullable value)
        : this(
            (OneOf<
                FieldAsDecimalNullable,
                ParamAsDecimalNullable,
                LiteralAsDecimalNullable,
                ArithmeticDecimalNullableRow,
                RoundingDecimalNullableRow,
                DifferenceDecimalNullableRow,
                ConditionalDecimalNullableRow
            >)
                value
        )
    { }

    public DecimalNullableRow(LiteralAsDecimalNullable value)
        : this(
            (OneOf<
                FieldAsDecimalNullable,
                ParamAsDecimalNullable,
                LiteralAsDecimalNullable,
                ArithmeticDecimalNullableRow,
                RoundingDecimalNullableRow,
                DifferenceDecimalNullableRow,
                ConditionalDecimalNullableRow
            >)
                value
        )
    { }

    public DecimalNullableRow(ArithmeticDecimalNullableRow value)
        : this(
            (OneOf<
                FieldAsDecimalNullable,
                ParamAsDecimalNullable,
                LiteralAsDecimalNullable,
                ArithmeticDecimalNullableRow,
                RoundingDecimalNullableRow,
                DifferenceDecimalNullableRow,
                ConditionalDecimalNullableRow
            >)
                value
        )
    { }

    public DecimalNullableRow(RoundingDecimalNullableRow value)
        : this(
            (OneOf<
                FieldAsDecimalNullable,
                ParamAsDecimalNullable,
                LiteralAsDecimalNullable,
                ArithmeticDecimalNullableRow,
                RoundingDecimalNullableRow,
                DifferenceDecimalNullableRow,
                ConditionalDecimalNullableRow
            >)
                value
        )
    { }

    public DecimalNullableRow(DifferenceDecimalNullableRow value)
        : this(
            (OneOf<
                FieldAsDecimalNullable,
                ParamAsDecimalNullable,
                LiteralAsDecimalNullable,
                ArithmeticDecimalNullableRow,
                RoundingDecimalNullableRow,
                DifferenceDecimalNullableRow,
                ConditionalDecimalNullableRow
            >)
                value
        )
    { }

    public DecimalNullableRow(ConditionalDecimalNullableRow value)
        : this(
            (OneOf<
                FieldAsDecimalNullable,
                ParamAsDecimalNullable,
                LiteralAsDecimalNullable,
                ArithmeticDecimalNullableRow,
                RoundingDecimalNullableRow,
                DifferenceDecimalNullableRow,
                ConditionalDecimalNullableRow
            >)
                value
        )
    { }

    private DecimalNullableRow(
        OneOf<
            FieldAsDecimalNullable,
            ParamAsDecimalNullable,
            LiteralAsDecimalNullable,
            ArithmeticDecimalNullableRow,
            RoundingDecimalNullableRow,
            DifferenceDecimalNullableRow,
            ConditionalDecimalNullableRow
        > input
    )
        : base(input) { }
}
