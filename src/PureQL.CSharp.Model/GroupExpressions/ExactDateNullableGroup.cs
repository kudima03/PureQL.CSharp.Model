using OneOf;
using PureQL.CSharp.Model.Keys;
using PureQL.CSharp.Model.Literals;
using PureQL.CSharp.Model.Parameters;

namespace PureQL.CSharp.Model.GroupExpressions;

public sealed class ExactDateNullableGroup
    : OneOfBase<
        KeyDateNullable,
        ParamDateNullable,
        LiteralDateNullable,
        DateAddDaysDateNullableGroup,
        ConditionalDateNullableGroup,
        AggregateDateNullableGroup
    >
{
    public ExactDateNullableGroup(KeyDateNullable value)
        : this(
            (OneOf<
                KeyDateNullable,
                ParamDateNullable,
                LiteralDateNullable,
                DateAddDaysDateNullableGroup,
                ConditionalDateNullableGroup,
                AggregateDateNullableGroup
            >)
                value
        )
    { }

    public ExactDateNullableGroup(ParamDateNullable value)
        : this(
            (OneOf<
                KeyDateNullable,
                ParamDateNullable,
                LiteralDateNullable,
                DateAddDaysDateNullableGroup,
                ConditionalDateNullableGroup,
                AggregateDateNullableGroup
            >)
                value
        )
    { }

    public ExactDateNullableGroup(LiteralDateNullable value)
        : this(
            (OneOf<
                KeyDateNullable,
                ParamDateNullable,
                LiteralDateNullable,
                DateAddDaysDateNullableGroup,
                ConditionalDateNullableGroup,
                AggregateDateNullableGroup
            >)
                value
        )
    { }

    public ExactDateNullableGroup(DateAddDaysDateNullableGroup value)
        : this(
            (OneOf<
                KeyDateNullable,
                ParamDateNullable,
                LiteralDateNullable,
                DateAddDaysDateNullableGroup,
                ConditionalDateNullableGroup,
                AggregateDateNullableGroup
            >)
                value
        )
    { }

    public ExactDateNullableGroup(ConditionalDateNullableGroup value)
        : this(
            (OneOf<
                KeyDateNullable,
                ParamDateNullable,
                LiteralDateNullable,
                DateAddDaysDateNullableGroup,
                ConditionalDateNullableGroup,
                AggregateDateNullableGroup
            >)
                value
        )
    { }

    public ExactDateNullableGroup(AggregateDateNullableGroup value)
        : this(
            (OneOf<
                KeyDateNullable,
                ParamDateNullable,
                LiteralDateNullable,
                DateAddDaysDateNullableGroup,
                ConditionalDateNullableGroup,
                AggregateDateNullableGroup
            >)
                value
        )
    { }

    private ExactDateNullableGroup(
        OneOf<
            KeyDateNullable,
            ParamDateNullable,
            LiteralDateNullable,
            DateAddDaysDateNullableGroup,
            ConditionalDateNullableGroup,
            AggregateDateNullableGroup
        > input
    )
        : base(input) { }
}
