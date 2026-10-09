using OneOf;
using PureQL.CSharp.Model.Keys;
using PureQL.CSharp.Model.Literals;
using PureQL.CSharp.Model.Parameters;

namespace PureQL.CSharp.Model.GroupExpressions;

public sealed class TimeGroup
    : OneOfBase<
        KeyTime,
        ParamTime,
        LiteralTime,
        TimeAddSecondsTimeGroup,
        ConditionalTimeGroup,
        AggregateTimeGroup
    >
{
    public TimeGroup(KeyTime value)
        : this(
            (OneOf<
                KeyTime,
                ParamTime,
                LiteralTime,
                TimeAddSecondsTimeGroup,
                ConditionalTimeGroup,
                AggregateTimeGroup
            >)
                value
        )
    { }

    public TimeGroup(ParamTime value)
        : this(
            (OneOf<
                KeyTime,
                ParamTime,
                LiteralTime,
                TimeAddSecondsTimeGroup,
                ConditionalTimeGroup,
                AggregateTimeGroup
            >)
                value
        )
    { }

    public TimeGroup(LiteralTime value)
        : this(
            (OneOf<
                KeyTime,
                ParamTime,
                LiteralTime,
                TimeAddSecondsTimeGroup,
                ConditionalTimeGroup,
                AggregateTimeGroup
            >)
                value
        )
    { }

    public TimeGroup(TimeAddSecondsTimeGroup value)
        : this(
            (OneOf<
                KeyTime,
                ParamTime,
                LiteralTime,
                TimeAddSecondsTimeGroup,
                ConditionalTimeGroup,
                AggregateTimeGroup
            >)
                value
        )
    { }

    public TimeGroup(ConditionalTimeGroup value)
        : this(
            (OneOf<
                KeyTime,
                ParamTime,
                LiteralTime,
                TimeAddSecondsTimeGroup,
                ConditionalTimeGroup,
                AggregateTimeGroup
            >)
                value
        )
    { }

    public TimeGroup(AggregateTimeGroup value)
        : this(
            (OneOf<
                KeyTime,
                ParamTime,
                LiteralTime,
                TimeAddSecondsTimeGroup,
                ConditionalTimeGroup,
                AggregateTimeGroup
            >)
                value
        )
    { }

    private TimeGroup(
        OneOf<
            KeyTime,
            ParamTime,
            LiteralTime,
            TimeAddSecondsTimeGroup,
            ConditionalTimeGroup,
            AggregateTimeGroup
        > input
    )
        : base(input) { }
}
