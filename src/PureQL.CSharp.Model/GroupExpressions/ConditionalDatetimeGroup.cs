using OneOf;

namespace PureQL.CSharp.Model.GroupExpressions;

public sealed class ConditionalDatetimeGroup
    : OneOfBase<IfDatetimeGroup, CoalesceDatetimeGroup>
{
    public ConditionalDatetimeGroup(IfDatetimeGroup value)
        : this((OneOf<IfDatetimeGroup, CoalesceDatetimeGroup>)value) { }

    public ConditionalDatetimeGroup(CoalesceDatetimeGroup value)
        : this((OneOf<IfDatetimeGroup, CoalesceDatetimeGroup>)value) { }

    private ConditionalDatetimeGroup(OneOf<IfDatetimeGroup, CoalesceDatetimeGroup> input)
        : base(input) { }
}
