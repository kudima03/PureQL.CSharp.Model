using OneOf;
using PureQL.CSharp.Model.Literals;
using PureQL.CSharp.Model.Parameters;

namespace PureQL.CSharp.Model.TotalExpressions;

public sealed class ExactDatetimeNullableTotal
    : OneOfBase<
        ParamDatetimeNullable,
        LiteralDatetimeNullable,
        DatetimeAddSecondsDatetimeNullableTotal,
        ConditionalDatetimeNullableTotal,
        AggregateDatetimeNullableTotal
    >
{
    public ExactDatetimeNullableTotal(ParamDatetimeNullable value)
        : this(
            (OneOf<
                ParamDatetimeNullable,
                LiteralDatetimeNullable,
                DatetimeAddSecondsDatetimeNullableTotal,
                ConditionalDatetimeNullableTotal,
                AggregateDatetimeNullableTotal
            >)
                value
        )
    { }

    public ExactDatetimeNullableTotal(LiteralDatetimeNullable value)
        : this(
            (OneOf<
                ParamDatetimeNullable,
                LiteralDatetimeNullable,
                DatetimeAddSecondsDatetimeNullableTotal,
                ConditionalDatetimeNullableTotal,
                AggregateDatetimeNullableTotal
            >)
                value
        )
    { }

    public ExactDatetimeNullableTotal(DatetimeAddSecondsDatetimeNullableTotal value)
        : this(
            (OneOf<
                ParamDatetimeNullable,
                LiteralDatetimeNullable,
                DatetimeAddSecondsDatetimeNullableTotal,
                ConditionalDatetimeNullableTotal,
                AggregateDatetimeNullableTotal
            >)
                value
        )
    { }

    public ExactDatetimeNullableTotal(ConditionalDatetimeNullableTotal value)
        : this(
            (OneOf<
                ParamDatetimeNullable,
                LiteralDatetimeNullable,
                DatetimeAddSecondsDatetimeNullableTotal,
                ConditionalDatetimeNullableTotal,
                AggregateDatetimeNullableTotal
            >)
                value
        )
    { }

    public ExactDatetimeNullableTotal(AggregateDatetimeNullableTotal value)
        : this(
            (OneOf<
                ParamDatetimeNullable,
                LiteralDatetimeNullable,
                DatetimeAddSecondsDatetimeNullableTotal,
                ConditionalDatetimeNullableTotal,
                AggregateDatetimeNullableTotal
            >)
                value
        )
    { }

    private ExactDatetimeNullableTotal(
        OneOf<
            ParamDatetimeNullable,
            LiteralDatetimeNullable,
            DatetimeAddSecondsDatetimeNullableTotal,
            ConditionalDatetimeNullableTotal,
            AggregateDatetimeNullableTotal
        > input
    )
        : base(input) { }
}
