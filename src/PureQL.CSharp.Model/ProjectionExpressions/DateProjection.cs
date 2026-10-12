using OneOf;
using PureQL.CSharp.Model.Fields;
using PureQL.CSharp.Model.Literals;
using PureQL.CSharp.Model.Parameters;

namespace PureQL.CSharp.Model.ProjectionExpressions;

public sealed class DateProjection
    : OneOfBase<
        FieldDate,
        ParamDate,
        LiteralDate,
        DateAddDaysDateProjection,
        ConditionalDateProjection,
        AggregateDateProjection
    >
{
    public DateProjection(FieldDate value)
        : this(
            (OneOf<
                FieldDate,
                ParamDate,
                LiteralDate,
                DateAddDaysDateProjection,
                ConditionalDateProjection,
                AggregateDateProjection
            >)
                value
        )
    { }

    public DateProjection(ParamDate value)
        : this(
            (OneOf<
                FieldDate,
                ParamDate,
                LiteralDate,
                DateAddDaysDateProjection,
                ConditionalDateProjection,
                AggregateDateProjection
            >)
                value
        )
    { }

    public DateProjection(LiteralDate value)
        : this(
            (OneOf<
                FieldDate,
                ParamDate,
                LiteralDate,
                DateAddDaysDateProjection,
                ConditionalDateProjection,
                AggregateDateProjection
            >)
                value
        )
    { }

    public DateProjection(DateAddDaysDateProjection value)
        : this(
            (OneOf<
                FieldDate,
                ParamDate,
                LiteralDate,
                DateAddDaysDateProjection,
                ConditionalDateProjection,
                AggregateDateProjection
            >)
                value
        )
    { }

    public DateProjection(ConditionalDateProjection value)
        : this(
            (OneOf<
                FieldDate,
                ParamDate,
                LiteralDate,
                DateAddDaysDateProjection,
                ConditionalDateProjection,
                AggregateDateProjection
            >)
                value
        )
    { }

    public DateProjection(AggregateDateProjection value)
        : this(
            (OneOf<
                FieldDate,
                ParamDate,
                LiteralDate,
                DateAddDaysDateProjection,
                ConditionalDateProjection,
                AggregateDateProjection
            >)
                value
        )
    { }

    private DateProjection(
        OneOf<
            FieldDate,
            ParamDate,
            LiteralDate,
            DateAddDaysDateProjection,
            ConditionalDateProjection,
            AggregateDateProjection
        > input
    )
        : base(input) { }
}
