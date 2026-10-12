using OneOf;

namespace PureQL.CSharp.Model.ProjectionExpressions;

public sealed class AggregateStringNullableProjection
    : OneOfBase<MinStringNullableProjection, MaxStringNullableProjection>
{
    public AggregateStringNullableProjection(MinStringNullableProjection value)
        : this((OneOf<MinStringNullableProjection, MaxStringNullableProjection>)value) { }

    public AggregateStringNullableProjection(MaxStringNullableProjection value)
        : this((OneOf<MinStringNullableProjection, MaxStringNullableProjection>)value) { }

    private AggregateStringNullableProjection(
        OneOf<MinStringNullableProjection, MaxStringNullableProjection> input
    )
        : base(input) { }
}
