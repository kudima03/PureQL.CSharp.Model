using OneOf;
using PureQL.CSharp.Model.Fields;
using PureQL.CSharp.Model.Literals;
using PureQL.CSharp.Model.Parameters;

namespace PureQL.CSharp.Model.ProjectionExpressions;

public sealed class ExactDateNullableProjection
    : OneOfBase<
        FieldDateNullable,
        ParamDateNullable,
        LiteralDateNullable,
        DateAddDaysDateNullableProjection,
        ConditionalDateNullableProjection,
        AggregateDateNullableProjection
    >
{
    public ExactDateNullableProjection(FieldDateNullable value)
        : this(
            (OneOf<
                FieldDateNullable,
                ParamDateNullable,
                LiteralDateNullable,
                DateAddDaysDateNullableProjection,
                ConditionalDateNullableProjection,
                AggregateDateNullableProjection
            >)
                value
        )
    { }

    public ExactDateNullableProjection(ParamDateNullable value)
        : this(
            (OneOf<
                FieldDateNullable,
                ParamDateNullable,
                LiteralDateNullable,
                DateAddDaysDateNullableProjection,
                ConditionalDateNullableProjection,
                AggregateDateNullableProjection
            >)
                value
        )
    { }

    public ExactDateNullableProjection(LiteralDateNullable value)
        : this(
            (OneOf<
                FieldDateNullable,
                ParamDateNullable,
                LiteralDateNullable,
                DateAddDaysDateNullableProjection,
                ConditionalDateNullableProjection,
                AggregateDateNullableProjection
            >)
                value
        )
    { }

    public ExactDateNullableProjection(DateAddDaysDateNullableProjection value)
        : this(
            (OneOf<
                FieldDateNullable,
                ParamDateNullable,
                LiteralDateNullable,
                DateAddDaysDateNullableProjection,
                ConditionalDateNullableProjection,
                AggregateDateNullableProjection
            >)
                value
        )
    { }

    public ExactDateNullableProjection(ConditionalDateNullableProjection value)
        : this(
            (OneOf<
                FieldDateNullable,
                ParamDateNullable,
                LiteralDateNullable,
                DateAddDaysDateNullableProjection,
                ConditionalDateNullableProjection,
                AggregateDateNullableProjection
            >)
                value
        )
    { }

    public ExactDateNullableProjection(AggregateDateNullableProjection value)
        : this(
            (OneOf<
                FieldDateNullable,
                ParamDateNullable,
                LiteralDateNullable,
                DateAddDaysDateNullableProjection,
                ConditionalDateNullableProjection,
                AggregateDateNullableProjection
            >)
                value
        )
    { }

    private ExactDateNullableProjection(
        OneOf<
            FieldDateNullable,
            ParamDateNullable,
            LiteralDateNullable,
            DateAddDaysDateNullableProjection,
            ConditionalDateNullableProjection,
            AggregateDateNullableProjection
        > input
    )
        : base(input) { }
}
