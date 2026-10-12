using OneOf;

namespace PureQL.CSharp.Model.ProjectionExpressions;

public sealed class AggregateTimeNullableProjection
    : OneOfBase<
        AverageTimeNullableProjection,
        MinTimeNullableProjection,
        MaxTimeNullableProjection
    >
{
    public AggregateTimeNullableProjection(AverageTimeNullableProjection value)
        : this(
            (OneOf<
                AverageTimeNullableProjection,
                MinTimeNullableProjection,
                MaxTimeNullableProjection
            >)
                value
        )
    { }

    public AggregateTimeNullableProjection(MinTimeNullableProjection value)
        : this(
            (OneOf<
                AverageTimeNullableProjection,
                MinTimeNullableProjection,
                MaxTimeNullableProjection
            >)
                value
        )
    { }

    public AggregateTimeNullableProjection(MaxTimeNullableProjection value)
        : this(
            (OneOf<
                AverageTimeNullableProjection,
                MinTimeNullableProjection,
                MaxTimeNullableProjection
            >)
                value
        )
    { }

    private AggregateTimeNullableProjection(
        OneOf<
            AverageTimeNullableProjection,
            MinTimeNullableProjection,
            MaxTimeNullableProjection
        > input
    )
        : base(input) { }
}
