using OneOf;

namespace PureQL.CSharp.Model.ProjectionExpressions;

public sealed class ConditionalUuidProjection
    : OneOfBase<IfUuidProjection, CoalesceUuidProjection>
{
    public ConditionalUuidProjection(IfUuidProjection value)
        : this((OneOf<IfUuidProjection, CoalesceUuidProjection>)value) { }

    public ConditionalUuidProjection(CoalesceUuidProjection value)
        : this((OneOf<IfUuidProjection, CoalesceUuidProjection>)value) { }

    private ConditionalUuidProjection(
        OneOf<IfUuidProjection, CoalesceUuidProjection> input
    )
        : base(input) { }
}
