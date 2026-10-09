using OneOf;

namespace PureQL.CSharp.Model.ProjectionExpressions;

public sealed class ConditionalStringNullableProjection
    : OneOfBase<IfStringNullableProjection, CoalesceStringNullableProjection>
{
    public ConditionalStringNullableProjection(IfStringNullableProjection value)
        : this((OneOf<IfStringNullableProjection, CoalesceStringNullableProjection>)value)
    { }

    public ConditionalStringNullableProjection(CoalesceStringNullableProjection value)
        : this((OneOf<IfStringNullableProjection, CoalesceStringNullableProjection>)value)
    { }

    private ConditionalStringNullableProjection(
        OneOf<IfStringNullableProjection, CoalesceStringNullableProjection> input
    )
        : base(input) { }
}
