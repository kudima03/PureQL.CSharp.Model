using OneOf;
using PureQL.CSharp.Model.Fields;
using PureQL.CSharp.Model.Literals;
using PureQL.CSharp.Model.Parameters;

namespace PureQL.CSharp.Model.ProjectionExpressions;

public sealed class DateNullableProjection
    : OneOfBase<
        FieldAsDateNullable,
        ParamAsDateNullable,
        LiteralAsDateNullable,
        DateAddDaysDateNullableProjection,
        ConditionalDateNullableProjection,
        AggregateDateProjection
    >
{
    public DateNullableProjection(FieldAsDateNullable value)
        : this(
            (OneOf<
                FieldAsDateNullable,
                ParamAsDateNullable,
                LiteralAsDateNullable,
                DateAddDaysDateNullableProjection,
                ConditionalDateNullableProjection,
                AggregateDateProjection
            >)
                value
        )
    { }

    public DateNullableProjection(ParamAsDateNullable value)
        : this(
            (OneOf<
                FieldAsDateNullable,
                ParamAsDateNullable,
                LiteralAsDateNullable,
                DateAddDaysDateNullableProjection,
                ConditionalDateNullableProjection,
                AggregateDateProjection
            >)
                value
        )
    { }

    public DateNullableProjection(LiteralAsDateNullable value)
        : this(
            (OneOf<
                FieldAsDateNullable,
                ParamAsDateNullable,
                LiteralAsDateNullable,
                DateAddDaysDateNullableProjection,
                ConditionalDateNullableProjection,
                AggregateDateProjection
            >)
                value
        )
    { }

    public DateNullableProjection(DateAddDaysDateNullableProjection value)
        : this(
            (OneOf<
                FieldAsDateNullable,
                ParamAsDateNullable,
                LiteralAsDateNullable,
                DateAddDaysDateNullableProjection,
                ConditionalDateNullableProjection,
                AggregateDateProjection
            >)
                value
        )
    { }

    public DateNullableProjection(ConditionalDateNullableProjection value)
        : this(
            (OneOf<
                FieldAsDateNullable,
                ParamAsDateNullable,
                LiteralAsDateNullable,
                DateAddDaysDateNullableProjection,
                ConditionalDateNullableProjection,
                AggregateDateProjection
            >)
                value
        )
    { }

    public DateNullableProjection(AggregateDateProjection value)
        : this(
            (OneOf<
                FieldAsDateNullable,
                ParamAsDateNullable,
                LiteralAsDateNullable,
                DateAddDaysDateNullableProjection,
                ConditionalDateNullableProjection,
                AggregateDateProjection
            >)
                value
        )
    { }

    private DateNullableProjection(
        OneOf<
            FieldAsDateNullable,
            ParamAsDateNullable,
            LiteralAsDateNullable,
            DateAddDaysDateNullableProjection,
            ConditionalDateNullableProjection,
            AggregateDateProjection
        > input
    )
        : base(input) { }
}
