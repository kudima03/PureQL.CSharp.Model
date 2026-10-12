using OneOf;
using PureQL.CSharp.Model.Fields;
using PureQL.CSharp.Model.Literals;
using PureQL.CSharp.Model.Parameters;

namespace PureQL.CSharp.Model.ProjectionExpressions;

public sealed class TimeProjection
    : OneOfBase<
        FieldTime,
        ParamTime,
        LiteralTime,
        TimeAddSecondsTimeProjection,
        ConditionalTimeProjection,
        AggregateTimeProjection
    >
{
    public TimeProjection(FieldTime value)
        : this(
            (OneOf<
                FieldTime,
                ParamTime,
                LiteralTime,
                TimeAddSecondsTimeProjection,
                ConditionalTimeProjection,
                AggregateTimeProjection
            >)
                value
        )
    { }

    public TimeProjection(ParamTime value)
        : this(
            (OneOf<
                FieldTime,
                ParamTime,
                LiteralTime,
                TimeAddSecondsTimeProjection,
                ConditionalTimeProjection,
                AggregateTimeProjection
            >)
                value
        )
    { }

    public TimeProjection(LiteralTime value)
        : this(
            (OneOf<
                FieldTime,
                ParamTime,
                LiteralTime,
                TimeAddSecondsTimeProjection,
                ConditionalTimeProjection,
                AggregateTimeProjection
            >)
                value
        )
    { }

    public TimeProjection(TimeAddSecondsTimeProjection value)
        : this(
            (OneOf<
                FieldTime,
                ParamTime,
                LiteralTime,
                TimeAddSecondsTimeProjection,
                ConditionalTimeProjection,
                AggregateTimeProjection
            >)
                value
        )
    { }

    public TimeProjection(ConditionalTimeProjection value)
        : this(
            (OneOf<
                FieldTime,
                ParamTime,
                LiteralTime,
                TimeAddSecondsTimeProjection,
                ConditionalTimeProjection,
                AggregateTimeProjection
            >)
                value
        )
    { }

    public TimeProjection(AggregateTimeProjection value)
        : this(
            (OneOf<
                FieldTime,
                ParamTime,
                LiteralTime,
                TimeAddSecondsTimeProjection,
                ConditionalTimeProjection,
                AggregateTimeProjection
            >)
                value
        )
    { }

    private TimeProjection(
        OneOf<
            FieldTime,
            ParamTime,
            LiteralTime,
            TimeAddSecondsTimeProjection,
            ConditionalTimeProjection,
            AggregateTimeProjection
        > input
    )
        : base(input) { }
}
