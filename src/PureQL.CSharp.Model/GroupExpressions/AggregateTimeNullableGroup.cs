using OneOf;

namespace PureQL.CSharp.Model.GroupExpressions;

public sealed class AggregateTimeNullableGroup
    : OneOfBase<AverageTimeNullableGroup, MinTimeNullableGroup, MaxTimeNullableGroup>
{
    public AggregateTimeNullableGroup(AverageTimeNullableGroup value)
        : this(
            (OneOf<AverageTimeNullableGroup, MinTimeNullableGroup, MaxTimeNullableGroup>)
                value
        )
    { }

    public AggregateTimeNullableGroup(MinTimeNullableGroup value)
        : this(
            (OneOf<AverageTimeNullableGroup, MinTimeNullableGroup, MaxTimeNullableGroup>)
                value
        )
    { }

    public AggregateTimeNullableGroup(MaxTimeNullableGroup value)
        : this(
            (OneOf<AverageTimeNullableGroup, MinTimeNullableGroup, MaxTimeNullableGroup>)
                value
        )
    { }

    private AggregateTimeNullableGroup(
        OneOf<AverageTimeNullableGroup, MinTimeNullableGroup, MaxTimeNullableGroup> input
    )
        : base(input) { }
}
