using OneOf;

namespace PureQL.CSharp.Model.ProjectionExpressions;

public sealed class AggregateUuidNullableProjection
    : OneOfBase<MinUuidNullableProjection, MaxUuidNullableProjection>
{
    public AggregateUuidNullableProjection(MinUuidNullableProjection value)
        : this((OneOf<MinUuidNullableProjection, MaxUuidNullableProjection>)value) { }

    public AggregateUuidNullableProjection(MaxUuidNullableProjection value)
        : this((OneOf<MinUuidNullableProjection, MaxUuidNullableProjection>)value) { }

    private AggregateUuidNullableProjection(
        OneOf<MinUuidNullableProjection, MaxUuidNullableProjection> input
    )
        : base(input) { }
}
