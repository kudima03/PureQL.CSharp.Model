using OneOf;

namespace PureQL.CSharp.Model.ProjectionExpressions;

public sealed class ConditionalDecimalNullableProjection
    : OneOfBase<IfDecimalNullableProjection, CoalesceDecimalNullableProjection>
{
    public ConditionalDecimalNullableProjection(IfDecimalNullableProjection value)
        : this(
            (OneOf<IfDecimalNullableProjection, CoalesceDecimalNullableProjection>)value
        )
    { }

    public ConditionalDecimalNullableProjection(CoalesceDecimalNullableProjection value)
        : this(
            (OneOf<IfDecimalNullableProjection, CoalesceDecimalNullableProjection>)value
        )
    { }

    private ConditionalDecimalNullableProjection(
        OneOf<IfDecimalNullableProjection, CoalesceDecimalNullableProjection> input
    )
        : base(input) { }
}
