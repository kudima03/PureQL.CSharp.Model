using OneOf;

namespace PureQL.CSharp.Model.ProjectionExpressions;

public sealed class AggregateIntegerNullableProjection
    : OneOfBase<MinIntegerNullableProjection, MaxIntegerNullableProjection>
{
    public AggregateIntegerNullableProjection(MinIntegerNullableProjection value)
        : this((OneOf<MinIntegerNullableProjection, MaxIntegerNullableProjection>)value)
    { }

    public AggregateIntegerNullableProjection(MaxIntegerNullableProjection value)
        : this((OneOf<MinIntegerNullableProjection, MaxIntegerNullableProjection>)value)
    { }

    private AggregateIntegerNullableProjection(
        OneOf<MinIntegerNullableProjection, MaxIntegerNullableProjection> input
    )
        : base(input) { }
}
