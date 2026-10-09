using OneOf;

namespace PureQL.CSharp.Model.ProjectionExpressions;

public sealed class AggregateIntegerNullableProjection
    : OneOfBase<
        CountProjection,
        SumIntegerProjection,
        MinIntegerNullableProjection,
        MaxIntegerNullableProjection
    >
{
    public AggregateIntegerNullableProjection(CountProjection value)
        : this(
            (OneOf<
                CountProjection,
                SumIntegerProjection,
                MinIntegerNullableProjection,
                MaxIntegerNullableProjection
            >)
                value
        )
    { }

    public AggregateIntegerNullableProjection(SumIntegerProjection value)
        : this(
            (OneOf<
                CountProjection,
                SumIntegerProjection,
                MinIntegerNullableProjection,
                MaxIntegerNullableProjection
            >)
                value
        )
    { }

    public AggregateIntegerNullableProjection(MinIntegerNullableProjection value)
        : this(
            (OneOf<
                CountProjection,
                SumIntegerProjection,
                MinIntegerNullableProjection,
                MaxIntegerNullableProjection
            >)
                value
        )
    { }

    public AggregateIntegerNullableProjection(MaxIntegerNullableProjection value)
        : this(
            (OneOf<
                CountProjection,
                SumIntegerProjection,
                MinIntegerNullableProjection,
                MaxIntegerNullableProjection
            >)
                value
        )
    { }

    private AggregateIntegerNullableProjection(
        OneOf<
            CountProjection,
            SumIntegerProjection,
            MinIntegerNullableProjection,
            MaxIntegerNullableProjection
        > input
    )
        : base(input) { }
}
