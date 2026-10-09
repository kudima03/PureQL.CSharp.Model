using OneOf;
using PureQL.CSharp.Model.Keys;
using PureQL.CSharp.Model.Literals;
using PureQL.CSharp.Model.Parameters;

namespace PureQL.CSharp.Model.GroupExpressions;

public sealed class DateNullableGroup
    : OneOfBase<
        KeyAsDateNullable,
        ParamAsDateNullable,
        LiteralAsDateNullable,
        DateAddDaysDateNullableGroup,
        ConditionalDateNullableGroup,
        AggregateDateNullableGroup
    >
{
    public DateNullableGroup(KeyAsDateNullable value)
        : this(
            (OneOf<
                KeyAsDateNullable,
                ParamAsDateNullable,
                LiteralAsDateNullable,
                DateAddDaysDateNullableGroup,
                ConditionalDateNullableGroup,
                AggregateDateNullableGroup
            >)
                value
        )
    { }

    public DateNullableGroup(ParamAsDateNullable value)
        : this(
            (OneOf<
                KeyAsDateNullable,
                ParamAsDateNullable,
                LiteralAsDateNullable,
                DateAddDaysDateNullableGroup,
                ConditionalDateNullableGroup,
                AggregateDateNullableGroup
            >)
                value
        )
    { }

    public DateNullableGroup(LiteralAsDateNullable value)
        : this(
            (OneOf<
                KeyAsDateNullable,
                ParamAsDateNullable,
                LiteralAsDateNullable,
                DateAddDaysDateNullableGroup,
                ConditionalDateNullableGroup,
                AggregateDateNullableGroup
            >)
                value
        )
    { }

    public DateNullableGroup(DateAddDaysDateNullableGroup value)
        : this(
            (OneOf<
                KeyAsDateNullable,
                ParamAsDateNullable,
                LiteralAsDateNullable,
                DateAddDaysDateNullableGroup,
                ConditionalDateNullableGroup,
                AggregateDateNullableGroup
            >)
                value
        )
    { }

    public DateNullableGroup(ConditionalDateNullableGroup value)
        : this(
            (OneOf<
                KeyAsDateNullable,
                ParamAsDateNullable,
                LiteralAsDateNullable,
                DateAddDaysDateNullableGroup,
                ConditionalDateNullableGroup,
                AggregateDateNullableGroup
            >)
                value
        )
    { }

    public DateNullableGroup(AggregateDateNullableGroup value)
        : this(
            (OneOf<
                KeyAsDateNullable,
                ParamAsDateNullable,
                LiteralAsDateNullable,
                DateAddDaysDateNullableGroup,
                ConditionalDateNullableGroup,
                AggregateDateNullableGroup
            >)
                value
        )
    { }

    private DateNullableGroup(
        OneOf<
            KeyAsDateNullable,
            ParamAsDateNullable,
            LiteralAsDateNullable,
            DateAddDaysDateNullableGroup,
            ConditionalDateNullableGroup,
            AggregateDateNullableGroup
        > input
    )
        : base(input) { }
}
