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
        ConditionalTimeProjection
    >
{
    public TimeProjection(FieldTime value)
        : this(
            (OneOf<
                FieldTime,
                ParamTime,
                LiteralTime,
                TimeAddSecondsTimeProjection,
                ConditionalTimeProjection
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
                ConditionalTimeProjection
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
                ConditionalTimeProjection
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
                ConditionalTimeProjection
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
                ConditionalTimeProjection
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
            ConditionalTimeProjection
        > input
    )
        : base(input) { }
}
