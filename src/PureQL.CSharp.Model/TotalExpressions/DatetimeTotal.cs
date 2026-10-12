using OneOf;
using PureQL.CSharp.Model.Literals;
using PureQL.CSharp.Model.Parameters;

namespace PureQL.CSharp.Model.TotalExpressions;

public sealed class DatetimeTotal
    : OneOfBase<
        ParamDatetime,
        LiteralDatetime,
        DatetimeAddSecondsDatetimeTotal,
        ConditionalDatetimeTotal
    >
{
    public DatetimeTotal(ParamDatetime value)
        : this(
            (OneOf<
                ParamDatetime,
                LiteralDatetime,
                DatetimeAddSecondsDatetimeTotal,
                ConditionalDatetimeTotal
            >)
                value
        )
    { }

    public DatetimeTotal(LiteralDatetime value)
        : this(
            (OneOf<
                ParamDatetime,
                LiteralDatetime,
                DatetimeAddSecondsDatetimeTotal,
                ConditionalDatetimeTotal
            >)
                value
        )
    { }

    public DatetimeTotal(DatetimeAddSecondsDatetimeTotal value)
        : this(
            (OneOf<
                ParamDatetime,
                LiteralDatetime,
                DatetimeAddSecondsDatetimeTotal,
                ConditionalDatetimeTotal
            >)
                value
        )
    { }

    public DatetimeTotal(ConditionalDatetimeTotal value)
        : this(
            (OneOf<
                ParamDatetime,
                LiteralDatetime,
                DatetimeAddSecondsDatetimeTotal,
                ConditionalDatetimeTotal
            >)
                value
        )
    { }

    private DatetimeTotal(
        OneOf<
            ParamDatetime,
            LiteralDatetime,
            DatetimeAddSecondsDatetimeTotal,
            ConditionalDatetimeTotal
        > input
    )
        : base(input) { }
}
