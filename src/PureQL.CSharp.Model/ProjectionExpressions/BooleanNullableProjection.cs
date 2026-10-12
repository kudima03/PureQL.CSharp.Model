using OneOf;

namespace PureQL.CSharp.Model.ProjectionExpressions;

public sealed class BooleanNullableProjection
    : OneOfBase<BooleanProjection, ExactBooleanNullableProjection>
{
    public BooleanNullableProjection(BooleanProjection value)
        : this((OneOf<BooleanProjection, ExactBooleanNullableProjection>)value) { }

    public BooleanNullableProjection(ExactBooleanNullableProjection value)
        : this((OneOf<BooleanProjection, ExactBooleanNullableProjection>)value) { }

    private BooleanNullableProjection(
        OneOf<BooleanProjection, ExactBooleanNullableProjection> input
    )
        : base(input) { }
}
