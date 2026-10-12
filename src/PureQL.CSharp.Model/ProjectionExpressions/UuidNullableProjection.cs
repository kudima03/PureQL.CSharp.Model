using OneOf;

namespace PureQL.CSharp.Model.ProjectionExpressions;

public sealed class UuidNullableProjection
    : OneOfBase<UuidProjection, ExactUuidNullableProjection>
{
    public UuidNullableProjection(UuidProjection value)
        : this((OneOf<UuidProjection, ExactUuidNullableProjection>)value) { }

    public UuidNullableProjection(ExactUuidNullableProjection value)
        : this((OneOf<UuidProjection, ExactUuidNullableProjection>)value) { }

    private UuidNullableProjection(
        OneOf<UuidProjection, ExactUuidNullableProjection> input
    )
        : base(input) { }
}
