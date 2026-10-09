using OneOf;
using PureQL.CSharp.Model.Fields;
using PureQL.CSharp.Model.Literals;
using PureQL.CSharp.Model.Parameters;

namespace PureQL.CSharp.Model.RowExpressions;

public sealed class DatetimeNullableRow
    : OneOfBase<
        FieldAsDatetimeNullable,
        ParamAsDatetimeNullable,
        LiteralAsDatetimeNullable,
        DatetimeAddSecondsDatetimeNullableRow,
        ConditionalDatetimeNullableRow
    >
{
    public DatetimeNullableRow(FieldAsDatetimeNullable value)
        : this(
            (OneOf<
                FieldAsDatetimeNullable,
                ParamAsDatetimeNullable,
                LiteralAsDatetimeNullable,
                DatetimeAddSecondsDatetimeNullableRow,
                ConditionalDatetimeNullableRow
            >)
                value
        )
    { }

    public DatetimeNullableRow(ParamAsDatetimeNullable value)
        : this(
            (OneOf<
                FieldAsDatetimeNullable,
                ParamAsDatetimeNullable,
                LiteralAsDatetimeNullable,
                DatetimeAddSecondsDatetimeNullableRow,
                ConditionalDatetimeNullableRow
            >)
                value
        )
    { }

    public DatetimeNullableRow(LiteralAsDatetimeNullable value)
        : this(
            (OneOf<
                FieldAsDatetimeNullable,
                ParamAsDatetimeNullable,
                LiteralAsDatetimeNullable,
                DatetimeAddSecondsDatetimeNullableRow,
                ConditionalDatetimeNullableRow
            >)
                value
        )
    { }

    public DatetimeNullableRow(DatetimeAddSecondsDatetimeNullableRow value)
        : this(
            (OneOf<
                FieldAsDatetimeNullable,
                ParamAsDatetimeNullable,
                LiteralAsDatetimeNullable,
                DatetimeAddSecondsDatetimeNullableRow,
                ConditionalDatetimeNullableRow
            >)
                value
        )
    { }

    public DatetimeNullableRow(ConditionalDatetimeNullableRow value)
        : this(
            (OneOf<
                FieldAsDatetimeNullable,
                ParamAsDatetimeNullable,
                LiteralAsDatetimeNullable,
                DatetimeAddSecondsDatetimeNullableRow,
                ConditionalDatetimeNullableRow
            >)
                value
        )
    { }

    private DatetimeNullableRow(
        OneOf<
            FieldAsDatetimeNullable,
            ParamAsDatetimeNullable,
            LiteralAsDatetimeNullable,
            DatetimeAddSecondsDatetimeNullableRow,
            ConditionalDatetimeNullableRow
        > input
    )
        : base(input) { }
}
