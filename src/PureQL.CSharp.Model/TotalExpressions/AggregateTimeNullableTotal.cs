using OneOf;

namespace PureQL.CSharp.Model.TotalExpressions;

public sealed class AggregateTimeNullableTotal
    : OneOfBase<AverageTimeNullableTotal, MinTimeNullableTotal, MaxTimeNullableTotal>
{
    public AggregateTimeNullableTotal(AverageTimeNullableTotal value)
        : this(
            (OneOf<AverageTimeNullableTotal, MinTimeNullableTotal, MaxTimeNullableTotal>)
                value
        )
    { }

    public AggregateTimeNullableTotal(MinTimeNullableTotal value)
        : this(
            (OneOf<AverageTimeNullableTotal, MinTimeNullableTotal, MaxTimeNullableTotal>)
                value
        )
    { }

    public AggregateTimeNullableTotal(MaxTimeNullableTotal value)
        : this(
            (OneOf<AverageTimeNullableTotal, MinTimeNullableTotal, MaxTimeNullableTotal>)
                value
        )
    { }

    private AggregateTimeNullableTotal(
        OneOf<AverageTimeNullableTotal, MinTimeNullableTotal, MaxTimeNullableTotal> input
    )
        : base(input) { }
}
