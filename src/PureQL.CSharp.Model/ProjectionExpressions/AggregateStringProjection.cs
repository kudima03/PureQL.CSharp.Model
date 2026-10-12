using OneOf;

namespace PureQL.CSharp.Model.ProjectionExpressions;

public sealed class AggregateStringProjection
    : OneOfBase<MinStringProjection, MaxStringProjection>
{
    public AggregateStringProjection(MinStringProjection value)
        : this((OneOf<MinStringProjection, MaxStringProjection>)value) { }

    public AggregateStringProjection(MaxStringProjection value)
        : this((OneOf<MinStringProjection, MaxStringProjection>)value) { }

    private AggregateStringProjection(
        OneOf<MinStringProjection, MaxStringProjection> input
    )
        : base(input) { }
}
