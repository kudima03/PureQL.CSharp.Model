using OneOf;

namespace PureQL.CSharp.Model.GroupExpressions;

public sealed class ConditionalDateGroup : OneOfBase<IfDateGroup, CoalesceDateGroup>
{
    public ConditionalDateGroup(IfDateGroup value)
        : this((OneOf<IfDateGroup, CoalesceDateGroup>)value) { }

    public ConditionalDateGroup(CoalesceDateGroup value)
        : this((OneOf<IfDateGroup, CoalesceDateGroup>)value) { }

    private ConditionalDateGroup(OneOf<IfDateGroup, CoalesceDateGroup> input)
        : base(input) { }
}
