using OneOf;

namespace PureQL.CSharp.Model.GroupExpressions;

public sealed class ConditionalStringGroup : OneOfBase<IfStringGroup, CoalesceStringGroup>
{
    public ConditionalStringGroup(IfStringGroup value)
        : this((OneOf<IfStringGroup, CoalesceStringGroup>)value) { }

    public ConditionalStringGroup(CoalesceStringGroup value)
        : this((OneOf<IfStringGroup, CoalesceStringGroup>)value) { }

    private ConditionalStringGroup(OneOf<IfStringGroup, CoalesceStringGroup> input)
        : base(input) { }
}
