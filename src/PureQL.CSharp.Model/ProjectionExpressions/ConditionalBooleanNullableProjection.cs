using OneOf;

namespace PureQL.CSharp.Model.ProjectionExpressions;

public sealed class ConditionalBooleanNullableProjection
    : OneOfBase<IfBooleanNullableProjection, CoalesceBooleanNullableProjection>
{
    public ConditionalBooleanNullableProjection(IfBooleanNullableProjection value)
        : this(
            (OneOf<IfBooleanNullableProjection, CoalesceBooleanNullableProjection>)value
        )
    { }

    public ConditionalBooleanNullableProjection(CoalesceBooleanNullableProjection value)
        : this(
            (OneOf<IfBooleanNullableProjection, CoalesceBooleanNullableProjection>)value
        )
    { }

    private ConditionalBooleanNullableProjection(
        OneOf<IfBooleanNullableProjection, CoalesceBooleanNullableProjection> input
    )
        : base(input) { }
}
