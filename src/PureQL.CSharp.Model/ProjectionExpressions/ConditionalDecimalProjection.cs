using OneOf;

namespace PureQL.CSharp.Model.ProjectionExpressions;

public sealed class ConditionalDecimalProjection
    : OneOfBase<IfDecimalProjection, CoalesceDecimalProjection>
{
    public ConditionalDecimalProjection(IfDecimalProjection value)
        : this((OneOf<IfDecimalProjection, CoalesceDecimalProjection>)value) { }

    public ConditionalDecimalProjection(CoalesceDecimalProjection value)
        : this((OneOf<IfDecimalProjection, CoalesceDecimalProjection>)value) { }

    private ConditionalDecimalProjection(
        OneOf<IfDecimalProjection, CoalesceDecimalProjection> input
    )
        : base(input) { }
}
