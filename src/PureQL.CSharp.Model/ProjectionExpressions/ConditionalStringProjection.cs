using OneOf;

namespace PureQL.CSharp.Model.ProjectionExpressions;

public sealed class ConditionalStringProjection
    : OneOfBase<IfStringProjection, CoalesceStringProjection>
{
    public ConditionalStringProjection(IfStringProjection value)
        : this((OneOf<IfStringProjection, CoalesceStringProjection>)value) { }

    public ConditionalStringProjection(CoalesceStringProjection value)
        : this((OneOf<IfStringProjection, CoalesceStringProjection>)value) { }

    private ConditionalStringProjection(
        OneOf<IfStringProjection, CoalesceStringProjection> input
    )
        : base(input) { }
}
