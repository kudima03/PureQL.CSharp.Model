using OneOf;

namespace PureQL.CSharp.Model.ProjectionExpressions;

public sealed class ConditionalTimeProjection
    : OneOfBase<IfTimeProjection, CoalesceTimeProjection>
{
    public ConditionalTimeProjection(IfTimeProjection value)
        : this((OneOf<IfTimeProjection, CoalesceTimeProjection>)value) { }

    public ConditionalTimeProjection(CoalesceTimeProjection value)
        : this((OneOf<IfTimeProjection, CoalesceTimeProjection>)value) { }

    private ConditionalTimeProjection(
        OneOf<IfTimeProjection, CoalesceTimeProjection> input
    )
        : base(input) { }
}
