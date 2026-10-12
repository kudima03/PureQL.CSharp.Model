using OneOf;
using PureQL.CSharp.Model.Fields;
using PureQL.CSharp.Model.Literals;
using PureQL.CSharp.Model.Parameters;

namespace PureQL.CSharp.Model.ProjectionExpressions;

public sealed class ExactDatetimeNullableProjection
    : OneOfBase<
        FieldDatetimeNullable,
        ParamDatetimeNullable,
        LiteralDatetimeNullable,
        DatetimeAddSecondsDatetimeNullableProjection,
        ConditionalDatetimeNullableProjection,
        AggregateDatetimeNullableProjection
    >
{
    public ExactDatetimeNullableProjection(FieldDatetimeNullable value)
        : this(
            (OneOf<
                FieldDatetimeNullable,
                ParamDatetimeNullable,
                LiteralDatetimeNullable,
                DatetimeAddSecondsDatetimeNullableProjection,
                ConditionalDatetimeNullableProjection,
                AggregateDatetimeNullableProjection
            >)
                value
        )
    { }

    public ExactDatetimeNullableProjection(ParamDatetimeNullable value)
        : this(
            (OneOf<
                FieldDatetimeNullable,
                ParamDatetimeNullable,
                LiteralDatetimeNullable,
                DatetimeAddSecondsDatetimeNullableProjection,
                ConditionalDatetimeNullableProjection,
                AggregateDatetimeNullableProjection
            >)
                value
        )
    { }

    public ExactDatetimeNullableProjection(LiteralDatetimeNullable value)
        : this(
            (OneOf<
                FieldDatetimeNullable,
                ParamDatetimeNullable,
                LiteralDatetimeNullable,
                DatetimeAddSecondsDatetimeNullableProjection,
                ConditionalDatetimeNullableProjection,
                AggregateDatetimeNullableProjection
            >)
                value
        )
    { }

    public ExactDatetimeNullableProjection(
        DatetimeAddSecondsDatetimeNullableProjection value
    )
        : this(
            (OneOf<
                FieldDatetimeNullable,
                ParamDatetimeNullable,
                LiteralDatetimeNullable,
                DatetimeAddSecondsDatetimeNullableProjection,
                ConditionalDatetimeNullableProjection,
                AggregateDatetimeNullableProjection
            >)
                value
        )
    { }

    public ExactDatetimeNullableProjection(ConditionalDatetimeNullableProjection value)
        : this(
            (OneOf<
                FieldDatetimeNullable,
                ParamDatetimeNullable,
                LiteralDatetimeNullable,
                DatetimeAddSecondsDatetimeNullableProjection,
                ConditionalDatetimeNullableProjection,
                AggregateDatetimeNullableProjection
            >)
                value
        )
    { }

    public ExactDatetimeNullableProjection(AggregateDatetimeNullableProjection value)
        : this(
            (OneOf<
                FieldDatetimeNullable,
                ParamDatetimeNullable,
                LiteralDatetimeNullable,
                DatetimeAddSecondsDatetimeNullableProjection,
                ConditionalDatetimeNullableProjection,
                AggregateDatetimeNullableProjection
            >)
                value
        )
    { }

    private ExactDatetimeNullableProjection(
        OneOf<
            FieldDatetimeNullable,
            ParamDatetimeNullable,
            LiteralDatetimeNullable,
            DatetimeAddSecondsDatetimeNullableProjection,
            ConditionalDatetimeNullableProjection,
            AggregateDatetimeNullableProjection
        > input
    )
        : base(input) { }
}
