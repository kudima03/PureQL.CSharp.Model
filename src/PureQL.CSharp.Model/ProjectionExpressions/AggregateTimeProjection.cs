using OneOf;

namespace PureQL.CSharp.Model.ProjectionExpressions;

public sealed class AggregateTimeProjection
    : OneOfBase<
        AverageTimeNullableProjection,
        MinTimeNullableProjection,
        MaxTimeNullableProjection
    >
{
    public AggregateTimeProjection(AverageTimeNullableProjection value)
        : this(
            (OneOf<
                AverageTimeNullableProjection,
                MinTimeNullableProjection,
                MaxTimeNullableProjection
            >)
                value
        )
    { }

    public AggregateTimeProjection(MinTimeNullableProjection value)
        : this(
            (OneOf<
                AverageTimeNullableProjection,
                MinTimeNullableProjection,
                MaxTimeNullableProjection
            >)
                value
        )
    { }

    public AggregateTimeProjection(MaxTimeNullableProjection value)
        : this(
            (OneOf<
                AverageTimeNullableProjection,
                MinTimeNullableProjection,
                MaxTimeNullableProjection
            >)
                value
        )
    { }

    private AggregateTimeProjection(
        OneOf<
            AverageTimeNullableProjection,
            MinTimeNullableProjection,
            MaxTimeNullableProjection
        > input
    )
        : base(input) { }
}
