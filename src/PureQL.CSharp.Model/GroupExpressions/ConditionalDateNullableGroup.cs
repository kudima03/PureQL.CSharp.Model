using OneOf;

namespace PureQL.CSharp.Model.GroupExpressions;

public sealed class ConditionalDateNullableGroup
    : OneOfBase<IfDateNullableGroup, CoalesceDateNullableGroup>
{
    public ConditionalDateNullableGroup(IfDateNullableGroup value)
        : this((OneOf<IfDateNullableGroup, CoalesceDateNullableGroup>)value) { }

    public ConditionalDateNullableGroup(CoalesceDateNullableGroup value)
        : this((OneOf<IfDateNullableGroup, CoalesceDateNullableGroup>)value) { }

    private ConditionalDateNullableGroup(
        OneOf<IfDateNullableGroup, CoalesceDateNullableGroup> input
    )
        : base(input) { }
}
