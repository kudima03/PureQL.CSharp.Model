using OneOf;
using PureQL.CSharp.Model.Keys;
using PureQL.CSharp.Model.Literals;
using PureQL.CSharp.Model.Parameters;

namespace PureQL.CSharp.Model.GroupExpressions;

public sealed class DatetimeNullableGroup
    : OneOfBase<
        KeyAsDatetimeNullable,
        ParamAsDatetimeNullable,
        LiteralAsDatetimeNullable,
        DatetimeAddSecondsDatetimeNullableGroup,
        ConditionalDatetimeNullableGroup,
        AggregateDatetimeNullableGroup
    >
{
    public DatetimeNullableGroup(KeyAsDatetimeNullable value)
        : this(
            (OneOf<
                KeyAsDatetimeNullable,
                ParamAsDatetimeNullable,
                LiteralAsDatetimeNullable,
                DatetimeAddSecondsDatetimeNullableGroup,
                ConditionalDatetimeNullableGroup,
                AggregateDatetimeNullableGroup
            >)
                value
        )
    { }

    public DatetimeNullableGroup(ParamAsDatetimeNullable value)
        : this(
            (OneOf<
                KeyAsDatetimeNullable,
                ParamAsDatetimeNullable,
                LiteralAsDatetimeNullable,
                DatetimeAddSecondsDatetimeNullableGroup,
                ConditionalDatetimeNullableGroup,
                AggregateDatetimeNullableGroup
            >)
                value
        )
    { }

    public DatetimeNullableGroup(LiteralAsDatetimeNullable value)
        : this(
            (OneOf<
                KeyAsDatetimeNullable,
                ParamAsDatetimeNullable,
                LiteralAsDatetimeNullable,
                DatetimeAddSecondsDatetimeNullableGroup,
                ConditionalDatetimeNullableGroup,
                AggregateDatetimeNullableGroup
            >)
                value
        )
    { }

    public DatetimeNullableGroup(DatetimeAddSecondsDatetimeNullableGroup value)
        : this(
            (OneOf<
                KeyAsDatetimeNullable,
                ParamAsDatetimeNullable,
                LiteralAsDatetimeNullable,
                DatetimeAddSecondsDatetimeNullableGroup,
                ConditionalDatetimeNullableGroup,
                AggregateDatetimeNullableGroup
            >)
                value
        )
    { }

    public DatetimeNullableGroup(ConditionalDatetimeNullableGroup value)
        : this(
            (OneOf<
                KeyAsDatetimeNullable,
                ParamAsDatetimeNullable,
                LiteralAsDatetimeNullable,
                DatetimeAddSecondsDatetimeNullableGroup,
                ConditionalDatetimeNullableGroup,
                AggregateDatetimeNullableGroup
            >)
                value
        )
    { }

    public DatetimeNullableGroup(AggregateDatetimeNullableGroup value)
        : this(
            (OneOf<
                KeyAsDatetimeNullable,
                ParamAsDatetimeNullable,
                LiteralAsDatetimeNullable,
                DatetimeAddSecondsDatetimeNullableGroup,
                ConditionalDatetimeNullableGroup,
                AggregateDatetimeNullableGroup
            >)
                value
        )
    { }

    private DatetimeNullableGroup(
        OneOf<
            KeyAsDatetimeNullable,
            ParamAsDatetimeNullable,
            LiteralAsDatetimeNullable,
            DatetimeAddSecondsDatetimeNullableGroup,
            ConditionalDatetimeNullableGroup,
            AggregateDatetimeNullableGroup
        > input
    )
        : base(input) { }
}
