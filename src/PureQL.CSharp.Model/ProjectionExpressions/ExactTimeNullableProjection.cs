using OneOf;
using PureQL.CSharp.Model.Fields;
using PureQL.CSharp.Model.Literals;
using PureQL.CSharp.Model.Parameters;

namespace PureQL.CSharp.Model.ProjectionExpressions;

public sealed class ExactTimeNullableProjection
    : OneOfBase<
        FieldTimeNullable,
        ParamTimeNullable,
        LiteralTimeNullable,
        TimeAddSecondsTimeNullableProjection,
        ConditionalTimeNullableProjection,
        AggregateTimeNullableProjection
    >
{
    public ExactTimeNullableProjection(FieldTimeNullable value)
        : this(
            (OneOf<
                FieldTimeNullable,
                ParamTimeNullable,
                LiteralTimeNullable,
                TimeAddSecondsTimeNullableProjection,
                ConditionalTimeNullableProjection,
                AggregateTimeNullableProjection
            >)
                value
        )
    { }

    public ExactTimeNullableProjection(ParamTimeNullable value)
        : this(
            (OneOf<
                FieldTimeNullable,
                ParamTimeNullable,
                LiteralTimeNullable,
                TimeAddSecondsTimeNullableProjection,
                ConditionalTimeNullableProjection,
                AggregateTimeNullableProjection
            >)
                value
        )
    { }

    public ExactTimeNullableProjection(LiteralTimeNullable value)
        : this(
            (OneOf<
                FieldTimeNullable,
                ParamTimeNullable,
                LiteralTimeNullable,
                TimeAddSecondsTimeNullableProjection,
                ConditionalTimeNullableProjection,
                AggregateTimeNullableProjection
            >)
                value
        )
    { }

    public ExactTimeNullableProjection(TimeAddSecondsTimeNullableProjection value)
        : this(
            (OneOf<
                FieldTimeNullable,
                ParamTimeNullable,
                LiteralTimeNullable,
                TimeAddSecondsTimeNullableProjection,
                ConditionalTimeNullableProjection,
                AggregateTimeNullableProjection
            >)
                value
        )
    { }

    public ExactTimeNullableProjection(ConditionalTimeNullableProjection value)
        : this(
            (OneOf<
                FieldTimeNullable,
                ParamTimeNullable,
                LiteralTimeNullable,
                TimeAddSecondsTimeNullableProjection,
                ConditionalTimeNullableProjection,
                AggregateTimeNullableProjection
            >)
                value
        )
    { }

    public ExactTimeNullableProjection(AggregateTimeNullableProjection value)
        : this(
            (OneOf<
                FieldTimeNullable,
                ParamTimeNullable,
                LiteralTimeNullable,
                TimeAddSecondsTimeNullableProjection,
                ConditionalTimeNullableProjection,
                AggregateTimeNullableProjection
            >)
                value
        )
    { }

    private ExactTimeNullableProjection(
        OneOf<
            FieldTimeNullable,
            ParamTimeNullable,
            LiteralTimeNullable,
            TimeAddSecondsTimeNullableProjection,
            ConditionalTimeNullableProjection,
            AggregateTimeNullableProjection
        > input
    )
        : base(input) { }
}
