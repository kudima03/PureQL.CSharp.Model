using OneOf;

namespace PureQL.CSharp.Model.ProjectionExpressions;

public sealed class ConditionalIntegerNullableProjection
    : OneOfBase<IfIntegerNullableProjection, CoalesceIntegerNullableProjection>
{
    public ConditionalIntegerNullableProjection(IfIntegerNullableProjection value)
        : this(
            (OneOf<IfIntegerNullableProjection, CoalesceIntegerNullableProjection>)value
        )
    { }

    public ConditionalIntegerNullableProjection(CoalesceIntegerNullableProjection value)
        : this(
            (OneOf<IfIntegerNullableProjection, CoalesceIntegerNullableProjection>)value
        )
    { }

    private ConditionalIntegerNullableProjection(
        OneOf<IfIntegerNullableProjection, CoalesceIntegerNullableProjection> input
    )
        : base(input) { }
}
