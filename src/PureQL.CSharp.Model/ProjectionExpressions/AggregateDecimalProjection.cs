using OneOf;

namespace PureQL.CSharp.Model.ProjectionExpressions;

public sealed class AggregateDecimalProjection
    : OneOfBase<
        SumDecimalProjection,
        AverageDecimalProjection,
        MinDecimalProjection,
        MaxDecimalProjection
    >
{
    public AggregateDecimalProjection(SumDecimalProjection value)
        : this(
            (OneOf<
                SumDecimalProjection,
                AverageDecimalProjection,
                MinDecimalProjection,
                MaxDecimalProjection
            >)
                value
        )
    { }

    public AggregateDecimalProjection(AverageDecimalProjection value)
        : this(
            (OneOf<
                SumDecimalProjection,
                AverageDecimalProjection,
                MinDecimalProjection,
                MaxDecimalProjection
            >)
                value
        )
    { }

    public AggregateDecimalProjection(MinDecimalProjection value)
        : this(
            (OneOf<
                SumDecimalProjection,
                AverageDecimalProjection,
                MinDecimalProjection,
                MaxDecimalProjection
            >)
                value
        )
    { }

    public AggregateDecimalProjection(MaxDecimalProjection value)
        : this(
            (OneOf<
                SumDecimalProjection,
                AverageDecimalProjection,
                MinDecimalProjection,
                MaxDecimalProjection
            >)
                value
        )
    { }

    private AggregateDecimalProjection(
        OneOf<
            SumDecimalProjection,
            AverageDecimalProjection,
            MinDecimalProjection,
            MaxDecimalProjection
        > input
    )
        : base(input) { }
}
