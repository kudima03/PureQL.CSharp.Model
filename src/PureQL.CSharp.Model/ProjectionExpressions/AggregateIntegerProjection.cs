using OneOf;

namespace PureQL.CSharp.Model.ProjectionExpressions;

public sealed class AggregateIntegerProjection
    : OneOfBase<
        CountProjection,
        SumIntegerProjection,
        MinIntegerProjection,
        MaxIntegerProjection
    >
{
    public AggregateIntegerProjection(CountProjection value)
        : this(
            (OneOf<
                CountProjection,
                SumIntegerProjection,
                MinIntegerProjection,
                MaxIntegerProjection
            >)
                value
        )
    { }

    public AggregateIntegerProjection(SumIntegerProjection value)
        : this(
            (OneOf<
                CountProjection,
                SumIntegerProjection,
                MinIntegerProjection,
                MaxIntegerProjection
            >)
                value
        )
    { }

    public AggregateIntegerProjection(MinIntegerProjection value)
        : this(
            (OneOf<
                CountProjection,
                SumIntegerProjection,
                MinIntegerProjection,
                MaxIntegerProjection
            >)
                value
        )
    { }

    public AggregateIntegerProjection(MaxIntegerProjection value)
        : this(
            (OneOf<
                CountProjection,
                SumIntegerProjection,
                MinIntegerProjection,
                MaxIntegerProjection
            >)
                value
        )
    { }

    private AggregateIntegerProjection(
        OneOf<
            CountProjection,
            SumIntegerProjection,
            MinIntegerProjection,
            MaxIntegerProjection
        > input
    )
        : base(input) { }
}
