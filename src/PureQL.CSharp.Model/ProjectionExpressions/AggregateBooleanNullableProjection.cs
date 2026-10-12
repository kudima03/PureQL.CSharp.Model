using OneOf;

namespace PureQL.CSharp.Model.ProjectionExpressions;

public sealed class AggregateBooleanNullableProjection
    : OneOfBase<MinBooleanNullableProjection, MaxBooleanNullableProjection>
{
    public AggregateBooleanNullableProjection(MinBooleanNullableProjection value)
        : this((OneOf<MinBooleanNullableProjection, MaxBooleanNullableProjection>)value)
    { }

    public AggregateBooleanNullableProjection(MaxBooleanNullableProjection value)
        : this((OneOf<MinBooleanNullableProjection, MaxBooleanNullableProjection>)value)
    { }

    private AggregateBooleanNullableProjection(
        OneOf<MinBooleanNullableProjection, MaxBooleanNullableProjection> input
    )
        : base(input) { }
}
