using OneOf;
using PureQL.CSharp.Model.Fields;
using PureQL.CSharp.Model.Literals;
using PureQL.CSharp.Model.Parameters;

namespace PureQL.CSharp.Model.ProjectionExpressions;

public sealed class TimeNullableProjection
    : OneOfBase<
        FieldAsTimeNullable,
        ParamAsTimeNullable,
        LiteralAsTimeNullable,
        TimeAddSecondsTimeNullableProjection,
        ConditionalTimeNullableProjection,
        AggregateTimeProjection
    >
{
    public TimeNullableProjection(FieldAsTimeNullable value)
        : this(
            (OneOf<
                FieldAsTimeNullable,
                ParamAsTimeNullable,
                LiteralAsTimeNullable,
                TimeAddSecondsTimeNullableProjection,
                ConditionalTimeNullableProjection,
                AggregateTimeProjection
            >)
                value
        )
    { }

    public TimeNullableProjection(ParamAsTimeNullable value)
        : this(
            (OneOf<
                FieldAsTimeNullable,
                ParamAsTimeNullable,
                LiteralAsTimeNullable,
                TimeAddSecondsTimeNullableProjection,
                ConditionalTimeNullableProjection,
                AggregateTimeProjection
            >)
                value
        )
    { }

    public TimeNullableProjection(LiteralAsTimeNullable value)
        : this(
            (OneOf<
                FieldAsTimeNullable,
                ParamAsTimeNullable,
                LiteralAsTimeNullable,
                TimeAddSecondsTimeNullableProjection,
                ConditionalTimeNullableProjection,
                AggregateTimeProjection
            >)
                value
        )
    { }

    public TimeNullableProjection(TimeAddSecondsTimeNullableProjection value)
        : this(
            (OneOf<
                FieldAsTimeNullable,
                ParamAsTimeNullable,
                LiteralAsTimeNullable,
                TimeAddSecondsTimeNullableProjection,
                ConditionalTimeNullableProjection,
                AggregateTimeProjection
            >)
                value
        )
    { }

    public TimeNullableProjection(ConditionalTimeNullableProjection value)
        : this(
            (OneOf<
                FieldAsTimeNullable,
                ParamAsTimeNullable,
                LiteralAsTimeNullable,
                TimeAddSecondsTimeNullableProjection,
                ConditionalTimeNullableProjection,
                AggregateTimeProjection
            >)
                value
        )
    { }

    public TimeNullableProjection(AggregateTimeProjection value)
        : this(
            (OneOf<
                FieldAsTimeNullable,
                ParamAsTimeNullable,
                LiteralAsTimeNullable,
                TimeAddSecondsTimeNullableProjection,
                ConditionalTimeNullableProjection,
                AggregateTimeProjection
            >)
                value
        )
    { }

    private TimeNullableProjection(
        OneOf<
            FieldAsTimeNullable,
            ParamAsTimeNullable,
            LiteralAsTimeNullable,
            TimeAddSecondsTimeNullableProjection,
            ConditionalTimeNullableProjection,
            AggregateTimeProjection
        > input
    )
        : base(input) { }
}
