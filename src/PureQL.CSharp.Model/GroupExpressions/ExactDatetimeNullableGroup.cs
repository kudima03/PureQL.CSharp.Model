using OneOf;
using PureQL.CSharp.Model.Keys;
using PureQL.CSharp.Model.Literals;
using PureQL.CSharp.Model.Parameters;

namespace PureQL.CSharp.Model.GroupExpressions;

public sealed class ExactDatetimeNullableGroup
    : OneOfBase<
        KeyDatetimeNullable,
        ParamDatetimeNullable,
        LiteralDatetimeNullable,
        DatetimeAddSecondsDatetimeNullableGroup,
        ConditionalDatetimeNullableGroup,
        AggregateDatetimeNullableGroup
    >
{
    public ExactDatetimeNullableGroup(KeyDatetimeNullable value)
        : this(
            (OneOf<
                KeyDatetimeNullable,
                ParamDatetimeNullable,
                LiteralDatetimeNullable,
                DatetimeAddSecondsDatetimeNullableGroup,
                ConditionalDatetimeNullableGroup,
                AggregateDatetimeNullableGroup
            >)
                value
        )
    { }

    public ExactDatetimeNullableGroup(ParamDatetimeNullable value)
        : this(
            (OneOf<
                KeyDatetimeNullable,
                ParamDatetimeNullable,
                LiteralDatetimeNullable,
                DatetimeAddSecondsDatetimeNullableGroup,
                ConditionalDatetimeNullableGroup,
                AggregateDatetimeNullableGroup
            >)
                value
        )
    { }

    public ExactDatetimeNullableGroup(LiteralDatetimeNullable value)
        : this(
            (OneOf<
                KeyDatetimeNullable,
                ParamDatetimeNullable,
                LiteralDatetimeNullable,
                DatetimeAddSecondsDatetimeNullableGroup,
                ConditionalDatetimeNullableGroup,
                AggregateDatetimeNullableGroup
            >)
                value
        )
    { }

    public ExactDatetimeNullableGroup(DatetimeAddSecondsDatetimeNullableGroup value)
        : this(
            (OneOf<
                KeyDatetimeNullable,
                ParamDatetimeNullable,
                LiteralDatetimeNullable,
                DatetimeAddSecondsDatetimeNullableGroup,
                ConditionalDatetimeNullableGroup,
                AggregateDatetimeNullableGroup
            >)
                value
        )
    { }

    public ExactDatetimeNullableGroup(ConditionalDatetimeNullableGroup value)
        : this(
            (OneOf<
                KeyDatetimeNullable,
                ParamDatetimeNullable,
                LiteralDatetimeNullable,
                DatetimeAddSecondsDatetimeNullableGroup,
                ConditionalDatetimeNullableGroup,
                AggregateDatetimeNullableGroup
            >)
                value
        )
    { }

    public ExactDatetimeNullableGroup(AggregateDatetimeNullableGroup value)
        : this(
            (OneOf<
                KeyDatetimeNullable,
                ParamDatetimeNullable,
                LiteralDatetimeNullable,
                DatetimeAddSecondsDatetimeNullableGroup,
                ConditionalDatetimeNullableGroup,
                AggregateDatetimeNullableGroup
            >)
                value
        )
    { }

    private ExactDatetimeNullableGroup(
        OneOf<
            KeyDatetimeNullable,
            ParamDatetimeNullable,
            LiteralDatetimeNullable,
            DatetimeAddSecondsDatetimeNullableGroup,
            ConditionalDatetimeNullableGroup,
            AggregateDatetimeNullableGroup
        > input
    )
        : base(input) { }
}
