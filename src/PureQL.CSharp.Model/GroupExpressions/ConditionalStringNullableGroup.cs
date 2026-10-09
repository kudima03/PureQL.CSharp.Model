using OneOf;

namespace PureQL.CSharp.Model.GroupExpressions;

public sealed class ConditionalStringNullableGroup
    : OneOfBase<IfStringNullableGroup, CoalesceStringNullableGroup>
{
    public ConditionalStringNullableGroup(IfStringNullableGroup value)
        : this((OneOf<IfStringNullableGroup, CoalesceStringNullableGroup>)value) { }

    public ConditionalStringNullableGroup(CoalesceStringNullableGroup value)
        : this((OneOf<IfStringNullableGroup, CoalesceStringNullableGroup>)value) { }

    private ConditionalStringNullableGroup(
        OneOf<IfStringNullableGroup, CoalesceStringNullableGroup> input
    )
        : base(input) { }
}
