using OneOf;

namespace PureQL.CSharp.Model.ProjectionExpressions;

public sealed class ConditionalUuidNullableProjection
    : OneOfBase<IfUuidNullableProjection, CoalesceUuidNullableProjection>
{
    public ConditionalUuidNullableProjection(IfUuidNullableProjection value)
        : this((OneOf<IfUuidNullableProjection, CoalesceUuidNullableProjection>)value) { }

    public ConditionalUuidNullableProjection(CoalesceUuidNullableProjection value)
        : this((OneOf<IfUuidNullableProjection, CoalesceUuidNullableProjection>)value) { }

    private ConditionalUuidNullableProjection(
        OneOf<IfUuidNullableProjection, CoalesceUuidNullableProjection> input
    )
        : base(input) { }
}
