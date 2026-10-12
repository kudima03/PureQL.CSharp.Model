using OneOf;
using PureQL.CSharp.Model.Fields;
using PureQL.CSharp.Model.Literals;
using PureQL.CSharp.Model.Parameters;

namespace PureQL.CSharp.Model.RowExpressions;

public sealed class ExactDatetimeNullableRow
    : OneOfBase<
        FieldDatetimeNullable,
        ParamDatetimeNullable,
        LiteralDatetimeNullable,
        DatetimeAddSecondsDatetimeNullableRow,
        ConditionalDatetimeNullableRow
    >
{
    public ExactDatetimeNullableRow(FieldDatetimeNullable value)
        : this(
            (OneOf<
                FieldDatetimeNullable,
                ParamDatetimeNullable,
                LiteralDatetimeNullable,
                DatetimeAddSecondsDatetimeNullableRow,
                ConditionalDatetimeNullableRow
            >)
                value
        )
    { }

    public ExactDatetimeNullableRow(ParamDatetimeNullable value)
        : this(
            (OneOf<
                FieldDatetimeNullable,
                ParamDatetimeNullable,
                LiteralDatetimeNullable,
                DatetimeAddSecondsDatetimeNullableRow,
                ConditionalDatetimeNullableRow
            >)
                value
        )
    { }

    public ExactDatetimeNullableRow(LiteralDatetimeNullable value)
        : this(
            (OneOf<
                FieldDatetimeNullable,
                ParamDatetimeNullable,
                LiteralDatetimeNullable,
                DatetimeAddSecondsDatetimeNullableRow,
                ConditionalDatetimeNullableRow
            >)
                value
        )
    { }

    public ExactDatetimeNullableRow(DatetimeAddSecondsDatetimeNullableRow value)
        : this(
            (OneOf<
                FieldDatetimeNullable,
                ParamDatetimeNullable,
                LiteralDatetimeNullable,
                DatetimeAddSecondsDatetimeNullableRow,
                ConditionalDatetimeNullableRow
            >)
                value
        )
    { }

    public ExactDatetimeNullableRow(ConditionalDatetimeNullableRow value)
        : this(
            (OneOf<
                FieldDatetimeNullable,
                ParamDatetimeNullable,
                LiteralDatetimeNullable,
                DatetimeAddSecondsDatetimeNullableRow,
                ConditionalDatetimeNullableRow
            >)
                value
        )
    { }

    private ExactDatetimeNullableRow(
        OneOf<
            FieldDatetimeNullable,
            ParamDatetimeNullable,
            LiteralDatetimeNullable,
            DatetimeAddSecondsDatetimeNullableRow,
            ConditionalDatetimeNullableRow
        > input
    )
        : base(input) { }
}
