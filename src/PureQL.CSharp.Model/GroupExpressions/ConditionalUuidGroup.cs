using OneOf;

namespace PureQL.CSharp.Model.GroupExpressions;

public sealed class ConditionalUuidGroup : OneOfBase<IfUuidGroup, CoalesceUuidGroup>
{
    public ConditionalUuidGroup(IfUuidGroup value)
        : this((OneOf<IfUuidGroup, CoalesceUuidGroup>)value) { }

    public ConditionalUuidGroup(CoalesceUuidGroup value)
        : this((OneOf<IfUuidGroup, CoalesceUuidGroup>)value) { }

    private ConditionalUuidGroup(OneOf<IfUuidGroup, CoalesceUuidGroup> input)
        : base(input) { }
}
