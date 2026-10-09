using OneOf;
using PureQL.CSharp.Model.Fields;
using PureQL.CSharp.Model.Literals;
using PureQL.CSharp.Model.Parameters;

namespace PureQL.CSharp.Model.ProjectionExpressions;

public sealed class DatetimeNullableProjection
    : OneOfBase<
        FieldAsDatetimeNullable,
        ParamAsDatetimeNullable,
        LiteralAsDatetimeNullable,
        DatetimeAddSecondsDatetimeNullableProjection,
        ConditionalDatetimeNullableProjection,
        AggregateDatetimeProjection
    >
{
    public DatetimeNullableProjection(FieldAsDatetimeNullable value)
        : this(
            (OneOf<
                FieldAsDatetimeNullable,
                ParamAsDatetimeNullable,
                LiteralAsDatetimeNullable,
                DatetimeAddSecondsDatetimeNullableProjection,
                ConditionalDatetimeNullableProjection,
                AggregateDatetimeProjection
            >)
                value
        )
    { }

    public DatetimeNullableProjection(ParamAsDatetimeNullable value)
        : this(
            (OneOf<
                FieldAsDatetimeNullable,
                ParamAsDatetimeNullable,
                LiteralAsDatetimeNullable,
                DatetimeAddSecondsDatetimeNullableProjection,
                ConditionalDatetimeNullableProjection,
                AggregateDatetimeProjection
            >)
                value
        )
    { }

    public DatetimeNullableProjection(LiteralAsDatetimeNullable value)
        : this(
            (OneOf<
                FieldAsDatetimeNullable,
                ParamAsDatetimeNullable,
                LiteralAsDatetimeNullable,
                DatetimeAddSecondsDatetimeNullableProjection,
                ConditionalDatetimeNullableProjection,
                AggregateDatetimeProjection
            >)
                value
        )
    { }

    public DatetimeNullableProjection(DatetimeAddSecondsDatetimeNullableProjection value)
        : this(
            (OneOf<
                FieldAsDatetimeNullable,
                ParamAsDatetimeNullable,
                LiteralAsDatetimeNullable,
                DatetimeAddSecondsDatetimeNullableProjection,
                ConditionalDatetimeNullableProjection,
                AggregateDatetimeProjection
            >)
                value
        )
    { }

    public DatetimeNullableProjection(ConditionalDatetimeNullableProjection value)
        : this(
            (OneOf<
                FieldAsDatetimeNullable,
                ParamAsDatetimeNullable,
                LiteralAsDatetimeNullable,
                DatetimeAddSecondsDatetimeNullableProjection,
                ConditionalDatetimeNullableProjection,
                AggregateDatetimeProjection
            >)
                value
        )
    { }

    public DatetimeNullableProjection(AggregateDatetimeProjection value)
        : this(
            (OneOf<
                FieldAsDatetimeNullable,
                ParamAsDatetimeNullable,
                LiteralAsDatetimeNullable,
                DatetimeAddSecondsDatetimeNullableProjection,
                ConditionalDatetimeNullableProjection,
                AggregateDatetimeProjection
            >)
                value
        )
    { }

    private DatetimeNullableProjection(
        OneOf<
            FieldAsDatetimeNullable,
            ParamAsDatetimeNullable,
            LiteralAsDatetimeNullable,
            DatetimeAddSecondsDatetimeNullableProjection,
            ConditionalDatetimeNullableProjection,
            AggregateDatetimeProjection
        > input
    )
        : base(input) { }
}
