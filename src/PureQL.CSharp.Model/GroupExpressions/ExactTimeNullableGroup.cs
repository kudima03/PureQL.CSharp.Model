using OneOf;
using PureQL.CSharp.Model.Keys;
using PureQL.CSharp.Model.Literals;
using PureQL.CSharp.Model.Parameters;

namespace PureQL.CSharp.Model.GroupExpressions;

public sealed class ExactTimeNullableGroup
    : OneOfBase<
        KeyTimeNullable,
        ParamTimeNullable,
        LiteralTimeNullable,
        TimeAddSecondsTimeNullableGroup,
        ConditionalTimeNullableGroup,
        AggregateTimeNullableGroup
    >
{
    public ExactTimeNullableGroup(KeyTimeNullable value)
        : this(
            (OneOf<
                KeyTimeNullable,
                ParamTimeNullable,
                LiteralTimeNullable,
                TimeAddSecondsTimeNullableGroup,
                ConditionalTimeNullableGroup,
                AggregateTimeNullableGroup
            >)
                value
        )
    { }

    public ExactTimeNullableGroup(ParamTimeNullable value)
        : this(
            (OneOf<
                KeyTimeNullable,
                ParamTimeNullable,
                LiteralTimeNullable,
                TimeAddSecondsTimeNullableGroup,
                ConditionalTimeNullableGroup,
                AggregateTimeNullableGroup
            >)
                value
        )
    { }

    public ExactTimeNullableGroup(LiteralTimeNullable value)
        : this(
            (OneOf<
                KeyTimeNullable,
                ParamTimeNullable,
                LiteralTimeNullable,
                TimeAddSecondsTimeNullableGroup,
                ConditionalTimeNullableGroup,
                AggregateTimeNullableGroup
            >)
                value
        )
    { }

    public ExactTimeNullableGroup(TimeAddSecondsTimeNullableGroup value)
        : this(
            (OneOf<
                KeyTimeNullable,
                ParamTimeNullable,
                LiteralTimeNullable,
                TimeAddSecondsTimeNullableGroup,
                ConditionalTimeNullableGroup,
                AggregateTimeNullableGroup
            >)
                value
        )
    { }

    public ExactTimeNullableGroup(ConditionalTimeNullableGroup value)
        : this(
            (OneOf<
                KeyTimeNullable,
                ParamTimeNullable,
                LiteralTimeNullable,
                TimeAddSecondsTimeNullableGroup,
                ConditionalTimeNullableGroup,
                AggregateTimeNullableGroup
            >)
                value
        )
    { }

    public ExactTimeNullableGroup(AggregateTimeNullableGroup value)
        : this(
            (OneOf<
                KeyTimeNullable,
                ParamTimeNullable,
                LiteralTimeNullable,
                TimeAddSecondsTimeNullableGroup,
                ConditionalTimeNullableGroup,
                AggregateTimeNullableGroup
            >)
                value
        )
    { }

    private ExactTimeNullableGroup(
        OneOf<
            KeyTimeNullable,
            ParamTimeNullable,
            LiteralTimeNullable,
            TimeAddSecondsTimeNullableGroup,
            ConditionalTimeNullableGroup,
            AggregateTimeNullableGroup
        > input
    )
        : base(input) { }
}
