using OneOf;

namespace PureQL.CSharp.Model.ProjectionExpressions;

public sealed class AggregateStringProjection
    : OneOfBase<MinStringNullableProjection, MaxStringNullableProjection>
{
    public AggregateStringProjection(MinStringNullableProjection value)
        : this((OneOf<MinStringNullableProjection, MaxStringNullableProjection>)value) { }

    public AggregateStringProjection(MaxStringNullableProjection value)
        : this((OneOf<MinStringNullableProjection, MaxStringNullableProjection>)value) { }

    private AggregateStringProjection(
        OneOf<MinStringNullableProjection, MaxStringNullableProjection> input
    )
        : base(input) { }
}
