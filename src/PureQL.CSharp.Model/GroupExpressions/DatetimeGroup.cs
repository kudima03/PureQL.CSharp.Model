using OneOf;
using PureQL.CSharp.Model.Keys;
using PureQL.CSharp.Model.Literals;
using PureQL.CSharp.Model.Parameters;

namespace PureQL.CSharp.Model.GroupExpressions;

public sealed class DatetimeGroup
    : OneOfBase<
        KeyDatetime,
        ParamDatetime,
        LiteralDatetime,
        DatetimeAddSecondsDatetimeGroup,
        ConditionalDatetimeGroup,
        AggregateDatetimeGroup
    >
{
    public DatetimeGroup(KeyDatetime value)
        : this(
            (OneOf<
                KeyDatetime,
                ParamDatetime,
                LiteralDatetime,
                DatetimeAddSecondsDatetimeGroup,
                ConditionalDatetimeGroup,
                AggregateDatetimeGroup
            >)
                value
        )
    { }

    public DatetimeGroup(ParamDatetime value)
        : this(
            (OneOf<
                KeyDatetime,
                ParamDatetime,
                LiteralDatetime,
                DatetimeAddSecondsDatetimeGroup,
                ConditionalDatetimeGroup,
                AggregateDatetimeGroup
            >)
                value
        )
    { }

    public DatetimeGroup(LiteralDatetime value)
        : this(
            (OneOf<
                KeyDatetime,
                ParamDatetime,
                LiteralDatetime,
                DatetimeAddSecondsDatetimeGroup,
                ConditionalDatetimeGroup,
                AggregateDatetimeGroup
            >)
                value
        )
    { }

    public DatetimeGroup(DatetimeAddSecondsDatetimeGroup value)
        : this(
            (OneOf<
                KeyDatetime,
                ParamDatetime,
                LiteralDatetime,
                DatetimeAddSecondsDatetimeGroup,
                ConditionalDatetimeGroup,
                AggregateDatetimeGroup
            >)
                value
        )
    { }

    public DatetimeGroup(ConditionalDatetimeGroup value)
        : this(
            (OneOf<
                KeyDatetime,
                ParamDatetime,
                LiteralDatetime,
                DatetimeAddSecondsDatetimeGroup,
                ConditionalDatetimeGroup,
                AggregateDatetimeGroup
            >)
                value
        )
    { }

    public DatetimeGroup(AggregateDatetimeGroup value)
        : this(
            (OneOf<
                KeyDatetime,
                ParamDatetime,
                LiteralDatetime,
                DatetimeAddSecondsDatetimeGroup,
                ConditionalDatetimeGroup,
                AggregateDatetimeGroup
            >)
                value
        )
    { }

    private DatetimeGroup(
        OneOf<
            KeyDatetime,
            ParamDatetime,
            LiteralDatetime,
            DatetimeAddSecondsDatetimeGroup,
            ConditionalDatetimeGroup,
            AggregateDatetimeGroup
        > input
    )
        : base(input) { }
}
