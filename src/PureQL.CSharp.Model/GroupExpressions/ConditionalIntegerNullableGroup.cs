using OneOf;

namespace PureQL.CSharp.Model.GroupExpressions;

public sealed class ConditionalIntegerNullableGroup
    : OneOfBase<IfIntegerNullableGroup, CoalesceIntegerNullableGroup>
{
    public ConditionalIntegerNullableGroup(IfIntegerNullableGroup value)
        : this((OneOf<IfIntegerNullableGroup, CoalesceIntegerNullableGroup>)value) { }

    public ConditionalIntegerNullableGroup(CoalesceIntegerNullableGroup value)
        : this((OneOf<IfIntegerNullableGroup, CoalesceIntegerNullableGroup>)value) { }

    private ConditionalIntegerNullableGroup(
        OneOf<IfIntegerNullableGroup, CoalesceIntegerNullableGroup> input
    )
        : base(input) { }
}
