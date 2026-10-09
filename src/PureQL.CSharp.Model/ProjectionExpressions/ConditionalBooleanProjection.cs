using OneOf;

namespace PureQL.CSharp.Model.ProjectionExpressions;

public sealed class ConditionalBooleanProjection
    : OneOfBase<IfBooleanProjection, CoalesceBooleanProjection>
{
    public ConditionalBooleanProjection(IfBooleanProjection value)
        : this((OneOf<IfBooleanProjection, CoalesceBooleanProjection>)value) { }

    public ConditionalBooleanProjection(CoalesceBooleanProjection value)
        : this((OneOf<IfBooleanProjection, CoalesceBooleanProjection>)value) { }

    private ConditionalBooleanProjection(
        OneOf<IfBooleanProjection, CoalesceBooleanProjection> input
    )
        : base(input) { }
}
