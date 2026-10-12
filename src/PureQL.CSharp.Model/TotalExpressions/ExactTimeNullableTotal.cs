using OneOf;
using PureQL.CSharp.Model.Literals;
using PureQL.CSharp.Model.Parameters;

namespace PureQL.CSharp.Model.TotalExpressions;

public sealed class ExactTimeNullableTotal
    : OneOfBase<
        ParamTimeNullable,
        LiteralTimeNullable,
        TimeAddSecondsTimeNullableTotal,
        ConditionalTimeNullableTotal,
        AggregateTimeNullableTotal
    >
{
    public ExactTimeNullableTotal(ParamTimeNullable value)
        : this(
            (OneOf<
                ParamTimeNullable,
                LiteralTimeNullable,
                TimeAddSecondsTimeNullableTotal,
                ConditionalTimeNullableTotal,
                AggregateTimeNullableTotal
            >)
                value
        )
    { }

    public ExactTimeNullableTotal(LiteralTimeNullable value)
        : this(
            (OneOf<
                ParamTimeNullable,
                LiteralTimeNullable,
                TimeAddSecondsTimeNullableTotal,
                ConditionalTimeNullableTotal,
                AggregateTimeNullableTotal
            >)
                value
        )
    { }

    public ExactTimeNullableTotal(TimeAddSecondsTimeNullableTotal value)
        : this(
            (OneOf<
                ParamTimeNullable,
                LiteralTimeNullable,
                TimeAddSecondsTimeNullableTotal,
                ConditionalTimeNullableTotal,
                AggregateTimeNullableTotal
            >)
                value
        )
    { }

    public ExactTimeNullableTotal(ConditionalTimeNullableTotal value)
        : this(
            (OneOf<
                ParamTimeNullable,
                LiteralTimeNullable,
                TimeAddSecondsTimeNullableTotal,
                ConditionalTimeNullableTotal,
                AggregateTimeNullableTotal
            >)
                value
        )
    { }

    public ExactTimeNullableTotal(AggregateTimeNullableTotal value)
        : this(
            (OneOf<
                ParamTimeNullable,
                LiteralTimeNullable,
                TimeAddSecondsTimeNullableTotal,
                ConditionalTimeNullableTotal,
                AggregateTimeNullableTotal
            >)
                value
        )
    { }

    private ExactTimeNullableTotal(
        OneOf<
            ParamTimeNullable,
            LiteralTimeNullable,
            TimeAddSecondsTimeNullableTotal,
            ConditionalTimeNullableTotal,
            AggregateTimeNullableTotal
        > input
    )
        : base(input) { }
}
