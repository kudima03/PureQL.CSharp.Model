using OneOf;

namespace PureQL.CSharp.Model.GroupExpressions;

public sealed class ConditionalBooleanNullableGroup
    : OneOfBase<IfBooleanNullableGroup, CoalesceBooleanNullableGroup>
{
    public ConditionalBooleanNullableGroup(IfBooleanNullableGroup value)
        : this((OneOf<IfBooleanNullableGroup, CoalesceBooleanNullableGroup>)value) { }

    public ConditionalBooleanNullableGroup(CoalesceBooleanNullableGroup value)
        : this((OneOf<IfBooleanNullableGroup, CoalesceBooleanNullableGroup>)value) { }

    private ConditionalBooleanNullableGroup(
        OneOf<IfBooleanNullableGroup, CoalesceBooleanNullableGroup> input
    )
        : base(input) { }
}
