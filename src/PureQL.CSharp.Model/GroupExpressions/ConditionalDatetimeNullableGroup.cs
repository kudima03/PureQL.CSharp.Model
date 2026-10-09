using OneOf;

namespace PureQL.CSharp.Model.GroupExpressions;

public sealed class ConditionalDatetimeNullableGroup
    : OneOfBase<IfDatetimeNullableGroup, CoalesceDatetimeNullableGroup>
{
    public ConditionalDatetimeNullableGroup(IfDatetimeNullableGroup value)
        : this((OneOf<IfDatetimeNullableGroup, CoalesceDatetimeNullableGroup>)value) { }

    public ConditionalDatetimeNullableGroup(CoalesceDatetimeNullableGroup value)
        : this((OneOf<IfDatetimeNullableGroup, CoalesceDatetimeNullableGroup>)value) { }

    private ConditionalDatetimeNullableGroup(
        OneOf<IfDatetimeNullableGroup, CoalesceDatetimeNullableGroup> input
    )
        : base(input) { }
}
