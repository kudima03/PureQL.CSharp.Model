using OneOf;

namespace PureQL.CSharp.Model.ProjectionExpressions;

public sealed class ConditionalTimeNullableProjection
    : OneOfBase<IfTimeNullableProjection, CoalesceTimeNullableProjection>
{
    public ConditionalTimeNullableProjection(IfTimeNullableProjection value)
        : this((OneOf<IfTimeNullableProjection, CoalesceTimeNullableProjection>)value) { }

    public ConditionalTimeNullableProjection(CoalesceTimeNullableProjection value)
        : this((OneOf<IfTimeNullableProjection, CoalesceTimeNullableProjection>)value) { }

    private ConditionalTimeNullableProjection(
        OneOf<IfTimeNullableProjection, CoalesceTimeNullableProjection> input
    )
        : base(input) { }
}
