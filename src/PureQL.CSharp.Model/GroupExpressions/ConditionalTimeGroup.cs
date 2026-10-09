using OneOf;

namespace PureQL.CSharp.Model.GroupExpressions;

public sealed class ConditionalTimeGroup : OneOfBase<IfTimeGroup, CoalesceTimeGroup>
{
    public ConditionalTimeGroup(IfTimeGroup value)
        : this((OneOf<IfTimeGroup, CoalesceTimeGroup>)value) { }

    public ConditionalTimeGroup(CoalesceTimeGroup value)
        : this((OneOf<IfTimeGroup, CoalesceTimeGroup>)value) { }

    private ConditionalTimeGroup(OneOf<IfTimeGroup, CoalesceTimeGroup> input)
        : base(input) { }
}
