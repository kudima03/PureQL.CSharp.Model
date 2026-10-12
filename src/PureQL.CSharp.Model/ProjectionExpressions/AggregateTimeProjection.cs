using OneOf;

namespace PureQL.CSharp.Model.ProjectionExpressions;

public sealed class AggregateTimeProjection
    : OneOfBase<AverageTimeProjection, MinTimeProjection, MaxTimeProjection>
{
    public AggregateTimeProjection(AverageTimeProjection value)
        : this((OneOf<AverageTimeProjection, MinTimeProjection, MaxTimeProjection>)value)
    { }

    public AggregateTimeProjection(MinTimeProjection value)
        : this((OneOf<AverageTimeProjection, MinTimeProjection, MaxTimeProjection>)value)
    { }

    public AggregateTimeProjection(MaxTimeProjection value)
        : this((OneOf<AverageTimeProjection, MinTimeProjection, MaxTimeProjection>)value)
    { }

    private AggregateTimeProjection(
        OneOf<AverageTimeProjection, MinTimeProjection, MaxTimeProjection> input
    )
        : base(input) { }
}
