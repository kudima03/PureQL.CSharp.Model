using OneOf;

namespace PureQL.CSharp.Model.ProjectionExpressions;

public sealed class AggregateDecimalNullableProjection
    : OneOfBase<
        CountProjection,
        SumDecimalProjection,
        AverageDecimalNullableProjection,
        MinDecimalNullableProjection,
        MaxDecimalNullableProjection
    >
{
    public AggregateDecimalNullableProjection(CountProjection value)
        : this(
            (OneOf<
                CountProjection,
                SumDecimalProjection,
                AverageDecimalNullableProjection,
                MinDecimalNullableProjection,
                MaxDecimalNullableProjection
            >)
                value
        )
    { }

    public AggregateDecimalNullableProjection(SumDecimalProjection value)
        : this(
            (OneOf<
                CountProjection,
                SumDecimalProjection,
                AverageDecimalNullableProjection,
                MinDecimalNullableProjection,
                MaxDecimalNullableProjection
            >)
                value
        )
    { }

    public AggregateDecimalNullableProjection(AverageDecimalNullableProjection value)
        : this(
            (OneOf<
                CountProjection,
                SumDecimalProjection,
                AverageDecimalNullableProjection,
                MinDecimalNullableProjection,
                MaxDecimalNullableProjection
            >)
                value
        )
    { }

    public AggregateDecimalNullableProjection(MinDecimalNullableProjection value)
        : this(
            (OneOf<
                CountProjection,
                SumDecimalProjection,
                AverageDecimalNullableProjection,
                MinDecimalNullableProjection,
                MaxDecimalNullableProjection
            >)
                value
        )
    { }

    public AggregateDecimalNullableProjection(MaxDecimalNullableProjection value)
        : this(
            (OneOf<
                CountProjection,
                SumDecimalProjection,
                AverageDecimalNullableProjection,
                MinDecimalNullableProjection,
                MaxDecimalNullableProjection
            >)
                value
        )
    { }

    private AggregateDecimalNullableProjection(
        OneOf<
            CountProjection,
            SumDecimalProjection,
            AverageDecimalNullableProjection,
            MinDecimalNullableProjection,
            MaxDecimalNullableProjection
        > input
    )
        : base(input) { }
}
