using OneOf;

namespace PureQL.CSharp.Model.GroupExpressions;

public sealed class ConditionalIntegerGroup
    : OneOfBase<IfIntegerGroup, CoalesceIntegerGroup>
{
    public ConditionalIntegerGroup(IfIntegerGroup value)
        : this((OneOf<IfIntegerGroup, CoalesceIntegerGroup>)value) { }

    public ConditionalIntegerGroup(CoalesceIntegerGroup value)
        : this((OneOf<IfIntegerGroup, CoalesceIntegerGroup>)value) { }

    private ConditionalIntegerGroup(OneOf<IfIntegerGroup, CoalesceIntegerGroup> input)
        : base(input) { }
}
