using OneOf;

namespace PureQL.CSharp.Model.GroupExpressions;

public sealed class ConditionalBooleanGroup
    : OneOfBase<IfBooleanGroup, CoalesceBooleanGroup>
{
    public ConditionalBooleanGroup(IfBooleanGroup value)
        : this((OneOf<IfBooleanGroup, CoalesceBooleanGroup>)value) { }

    public ConditionalBooleanGroup(CoalesceBooleanGroup value)
        : this((OneOf<IfBooleanGroup, CoalesceBooleanGroup>)value) { }

    private ConditionalBooleanGroup(OneOf<IfBooleanGroup, CoalesceBooleanGroup> input)
        : base(input) { }
}
