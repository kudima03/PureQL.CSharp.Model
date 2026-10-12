using OneOf;
using PureQL.CSharp.Model.Literals;
using PureQL.CSharp.Model.Parameters;

namespace PureQL.CSharp.Model.TotalExpressions;

public sealed class ExactDateNullableTotal
    : OneOfBase<
        ParamDateNullable,
        LiteralDateNullable,
        DateAddDaysDateNullableTotal,
        ConditionalDateNullableTotal,
        AggregateDateNullableTotal
    >
{
    public ExactDateNullableTotal(ParamDateNullable value)
        : this(
            (OneOf<
                ParamDateNullable,
                LiteralDateNullable,
                DateAddDaysDateNullableTotal,
                ConditionalDateNullableTotal,
                AggregateDateNullableTotal
            >)
                value
        )
    { }

    public ExactDateNullableTotal(LiteralDateNullable value)
        : this(
            (OneOf<
                ParamDateNullable,
                LiteralDateNullable,
                DateAddDaysDateNullableTotal,
                ConditionalDateNullableTotal,
                AggregateDateNullableTotal
            >)
                value
        )
    { }

    public ExactDateNullableTotal(DateAddDaysDateNullableTotal value)
        : this(
            (OneOf<
                ParamDateNullable,
                LiteralDateNullable,
                DateAddDaysDateNullableTotal,
                ConditionalDateNullableTotal,
                AggregateDateNullableTotal
            >)
                value
        )
    { }

    public ExactDateNullableTotal(ConditionalDateNullableTotal value)
        : this(
            (OneOf<
                ParamDateNullable,
                LiteralDateNullable,
                DateAddDaysDateNullableTotal,
                ConditionalDateNullableTotal,
                AggregateDateNullableTotal
            >)
                value
        )
    { }

    public ExactDateNullableTotal(AggregateDateNullableTotal value)
        : this(
            (OneOf<
                ParamDateNullable,
                LiteralDateNullable,
                DateAddDaysDateNullableTotal,
                ConditionalDateNullableTotal,
                AggregateDateNullableTotal
            >)
                value
        )
    { }

    private ExactDateNullableTotal(
        OneOf<
            ParamDateNullable,
            LiteralDateNullable,
            DateAddDaysDateNullableTotal,
            ConditionalDateNullableTotal,
            AggregateDateNullableTotal
        > input
    )
        : base(input) { }
}
