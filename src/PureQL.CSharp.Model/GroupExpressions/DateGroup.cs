using OneOf;
using PureQL.CSharp.Model.Keys;
using PureQL.CSharp.Model.Literals;
using PureQL.CSharp.Model.Parameters;

namespace PureQL.CSharp.Model.GroupExpressions;

public sealed class DateGroup
    : OneOfBase<
        KeyDate,
        ParamDate,
        LiteralDate,
        DateAddDaysDateGroup,
        ConditionalDateGroup,
        AggregateDateGroup
    >
{
    public DateGroup(KeyDate value)
        : this(
            (OneOf<
                KeyDate,
                ParamDate,
                LiteralDate,
                DateAddDaysDateGroup,
                ConditionalDateGroup,
                AggregateDateGroup
            >)
                value
        )
    { }

    public DateGroup(ParamDate value)
        : this(
            (OneOf<
                KeyDate,
                ParamDate,
                LiteralDate,
                DateAddDaysDateGroup,
                ConditionalDateGroup,
                AggregateDateGroup
            >)
                value
        )
    { }

    public DateGroup(LiteralDate value)
        : this(
            (OneOf<
                KeyDate,
                ParamDate,
                LiteralDate,
                DateAddDaysDateGroup,
                ConditionalDateGroup,
                AggregateDateGroup
            >)
                value
        )
    { }

    public DateGroup(DateAddDaysDateGroup value)
        : this(
            (OneOf<
                KeyDate,
                ParamDate,
                LiteralDate,
                DateAddDaysDateGroup,
                ConditionalDateGroup,
                AggregateDateGroup
            >)
                value
        )
    { }

    public DateGroup(ConditionalDateGroup value)
        : this(
            (OneOf<
                KeyDate,
                ParamDate,
                LiteralDate,
                DateAddDaysDateGroup,
                ConditionalDateGroup,
                AggregateDateGroup
            >)
                value
        )
    { }

    public DateGroup(AggregateDateGroup value)
        : this(
            (OneOf<
                KeyDate,
                ParamDate,
                LiteralDate,
                DateAddDaysDateGroup,
                ConditionalDateGroup,
                AggregateDateGroup
            >)
                value
        )
    { }

    private DateGroup(
        OneOf<
            KeyDate,
            ParamDate,
            LiteralDate,
            DateAddDaysDateGroup,
            ConditionalDateGroup,
            AggregateDateGroup
        > input
    )
        : base(input) { }
}
