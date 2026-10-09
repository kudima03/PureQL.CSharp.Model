using OneOf;

namespace PureQL.CSharp.Model.GroupExpressions;

public sealed class ConditionalDecimalGroup
    : OneOfBase<IfDecimalGroup, CoalesceDecimalGroup>
{
    public ConditionalDecimalGroup(IfDecimalGroup value)
        : this((OneOf<IfDecimalGroup, CoalesceDecimalGroup>)value) { }

    public ConditionalDecimalGroup(CoalesceDecimalGroup value)
        : this((OneOf<IfDecimalGroup, CoalesceDecimalGroup>)value) { }

    private ConditionalDecimalGroup(OneOf<IfDecimalGroup, CoalesceDecimalGroup> input)
        : base(input) { }
}
