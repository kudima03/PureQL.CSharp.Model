using OneOf;
using PureQL.CSharp.Model.Fields;
using PureQL.CSharp.Model.Literals;
using PureQL.CSharp.Model.Parameters;

namespace PureQL.CSharp.Model.ProjectionExpressions;

public sealed class DatetimeProjection
    : OneOfBase<
        FieldDatetime,
        ParamDatetime,
        LiteralDatetime,
        DatetimeAddSecondsDatetimeProjection,
        ConditionalDatetimeProjection,
        AggregateDatetimeProjection
    >
{
    public DatetimeProjection(FieldDatetime value)
        : this(
            (OneOf<
                FieldDatetime,
                ParamDatetime,
                LiteralDatetime,
                DatetimeAddSecondsDatetimeProjection,
                ConditionalDatetimeProjection,
                AggregateDatetimeProjection
            >)
                value
        )
    { }

    public DatetimeProjection(ParamDatetime value)
        : this(
            (OneOf<
                FieldDatetime,
                ParamDatetime,
                LiteralDatetime,
                DatetimeAddSecondsDatetimeProjection,
                ConditionalDatetimeProjection,
                AggregateDatetimeProjection
            >)
                value
        )
    { }

    public DatetimeProjection(LiteralDatetime value)
        : this(
            (OneOf<
                FieldDatetime,
                ParamDatetime,
                LiteralDatetime,
                DatetimeAddSecondsDatetimeProjection,
                ConditionalDatetimeProjection,
                AggregateDatetimeProjection
            >)
                value
        )
    { }

    public DatetimeProjection(DatetimeAddSecondsDatetimeProjection value)
        : this(
            (OneOf<
                FieldDatetime,
                ParamDatetime,
                LiteralDatetime,
                DatetimeAddSecondsDatetimeProjection,
                ConditionalDatetimeProjection,
                AggregateDatetimeProjection
            >)
                value
        )
    { }

    public DatetimeProjection(ConditionalDatetimeProjection value)
        : this(
            (OneOf<
                FieldDatetime,
                ParamDatetime,
                LiteralDatetime,
                DatetimeAddSecondsDatetimeProjection,
                ConditionalDatetimeProjection,
                AggregateDatetimeProjection
            >)
                value
        )
    { }

    public DatetimeProjection(AggregateDatetimeProjection value)
        : this(
            (OneOf<
                FieldDatetime,
                ParamDatetime,
                LiteralDatetime,
                DatetimeAddSecondsDatetimeProjection,
                ConditionalDatetimeProjection,
                AggregateDatetimeProjection
            >)
                value
        )
    { }

    private DatetimeProjection(
        OneOf<
            FieldDatetime,
            ParamDatetime,
            LiteralDatetime,
            DatetimeAddSecondsDatetimeProjection,
            ConditionalDatetimeProjection,
            AggregateDatetimeProjection
        > input
    )
        : base(input) { }
}
