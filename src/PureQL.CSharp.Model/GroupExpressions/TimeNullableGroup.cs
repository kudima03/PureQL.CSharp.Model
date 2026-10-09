using OneOf;
using PureQL.CSharp.Model.Keys;
using PureQL.CSharp.Model.Literals;
using PureQL.CSharp.Model.Parameters;

namespace PureQL.CSharp.Model.GroupExpressions;

public sealed class TimeNullableGroup
    : OneOfBase<
        KeyAsTimeNullable,
        ParamAsTimeNullable,
        LiteralAsTimeNullable,
        TimeAddSecondsTimeNullableGroup,
        ConditionalTimeNullableGroup,
        AggregateTimeNullableGroup
    >
{
    public TimeNullableGroup(KeyAsTimeNullable value)
        : this(
            (OneOf<
                KeyAsTimeNullable,
                ParamAsTimeNullable,
                LiteralAsTimeNullable,
                TimeAddSecondsTimeNullableGroup,
                ConditionalTimeNullableGroup,
                AggregateTimeNullableGroup
            >)
                value
        )
    { }

    public TimeNullableGroup(ParamAsTimeNullable value)
        : this(
            (OneOf<
                KeyAsTimeNullable,
                ParamAsTimeNullable,
                LiteralAsTimeNullable,
                TimeAddSecondsTimeNullableGroup,
                ConditionalTimeNullableGroup,
                AggregateTimeNullableGroup
            >)
                value
        )
    { }

    public TimeNullableGroup(LiteralAsTimeNullable value)
        : this(
            (OneOf<
                KeyAsTimeNullable,
                ParamAsTimeNullable,
                LiteralAsTimeNullable,
                TimeAddSecondsTimeNullableGroup,
                ConditionalTimeNullableGroup,
                AggregateTimeNullableGroup
            >)
                value
        )
    { }

    public TimeNullableGroup(TimeAddSecondsTimeNullableGroup value)
        : this(
            (OneOf<
                KeyAsTimeNullable,
                ParamAsTimeNullable,
                LiteralAsTimeNullable,
                TimeAddSecondsTimeNullableGroup,
                ConditionalTimeNullableGroup,
                AggregateTimeNullableGroup
            >)
                value
        )
    { }

    public TimeNullableGroup(ConditionalTimeNullableGroup value)
        : this(
            (OneOf<
                KeyAsTimeNullable,
                ParamAsTimeNullable,
                LiteralAsTimeNullable,
                TimeAddSecondsTimeNullableGroup,
                ConditionalTimeNullableGroup,
                AggregateTimeNullableGroup
            >)
                value
        )
    { }

    public TimeNullableGroup(AggregateTimeNullableGroup value)
        : this(
            (OneOf<
                KeyAsTimeNullable,
                ParamAsTimeNullable,
                LiteralAsTimeNullable,
                TimeAddSecondsTimeNullableGroup,
                ConditionalTimeNullableGroup,
                AggregateTimeNullableGroup
            >)
                value
        )
    { }

    private TimeNullableGroup(
        OneOf<
            KeyAsTimeNullable,
            ParamAsTimeNullable,
            LiteralAsTimeNullable,
            TimeAddSecondsTimeNullableGroup,
            ConditionalTimeNullableGroup,
            AggregateTimeNullableGroup
        > input
    )
        : base(input) { }
}
