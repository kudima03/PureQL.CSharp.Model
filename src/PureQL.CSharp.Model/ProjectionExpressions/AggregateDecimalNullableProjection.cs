using OneOf;

namespace PureQL.CSharp.Model.ProjectionExpressions;

public sealed class AggregateDecimalNullableProjection
    : OneOfBase<
        AverageDecimalNullableProjection,
        MinDecimalNullableProjection,
        MaxDecimalNullableProjection
    >
{
    public AggregateDecimalNullableProjection(AverageDecimalNullableProjection value)
        : this(
            (OneOf<
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
                AverageDecimalNullableProjection,
                MinDecimalNullableProjection,
                MaxDecimalNullableProjection
            >)
                value
        )
    { }

    private AggregateDecimalNullableProjection(
        OneOf<
            AverageDecimalNullableProjection,
            MinDecimalNullableProjection,
            MaxDecimalNullableProjection
        > input
    )
        : base(input) { }
}
