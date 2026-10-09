using OneOf;
using PureQL.CSharp.Model.Fields;
using PureQL.CSharp.Model.Literals;
using PureQL.CSharp.Model.Parameters;

namespace PureQL.CSharp.Model.RowExpressions;

public sealed class DatetimeRow
    : OneOfBase<
        FieldDatetime,
        ParamDatetime,
        LiteralDatetime,
        DatetimeAddSecondsDatetimeRow,
        ConditionalDatetimeRow
    >
{
    public DatetimeRow(FieldDatetime value)
        : this(
            (OneOf<
                FieldDatetime,
                ParamDatetime,
                LiteralDatetime,
                DatetimeAddSecondsDatetimeRow,
                ConditionalDatetimeRow
            >)
                value
        )
    { }

    public DatetimeRow(ParamDatetime value)
        : this(
            (OneOf<
                FieldDatetime,
                ParamDatetime,
                LiteralDatetime,
                DatetimeAddSecondsDatetimeRow,
                ConditionalDatetimeRow
            >)
                value
        )
    { }

    public DatetimeRow(LiteralDatetime value)
        : this(
            (OneOf<
                FieldDatetime,
                ParamDatetime,
                LiteralDatetime,
                DatetimeAddSecondsDatetimeRow,
                ConditionalDatetimeRow
            >)
                value
        )
    { }

    public DatetimeRow(DatetimeAddSecondsDatetimeRow value)
        : this(
            (OneOf<
                FieldDatetime,
                ParamDatetime,
                LiteralDatetime,
                DatetimeAddSecondsDatetimeRow,
                ConditionalDatetimeRow
            >)
                value
        )
    { }

    public DatetimeRow(ConditionalDatetimeRow value)
        : this(
            (OneOf<
                FieldDatetime,
                ParamDatetime,
                LiteralDatetime,
                DatetimeAddSecondsDatetimeRow,
                ConditionalDatetimeRow
            >)
                value
        )
    { }

    private DatetimeRow(
        OneOf<
            FieldDatetime,
            ParamDatetime,
            LiteralDatetime,
            DatetimeAddSecondsDatetimeRow,
            ConditionalDatetimeRow
        > input
    )
        : base(input) { }
}
