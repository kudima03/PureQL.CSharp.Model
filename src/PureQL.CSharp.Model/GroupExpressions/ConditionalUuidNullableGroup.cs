using OneOf;

namespace PureQL.CSharp.Model.GroupExpressions;

public sealed class ConditionalUuidNullableGroup
    : OneOfBase<IfUuidNullableGroup, CoalesceUuidNullableGroup>
{
    public ConditionalUuidNullableGroup(IfUuidNullableGroup value)
        : this((OneOf<IfUuidNullableGroup, CoalesceUuidNullableGroup>)value) { }

    public ConditionalUuidNullableGroup(CoalesceUuidNullableGroup value)
        : this((OneOf<IfUuidNullableGroup, CoalesceUuidNullableGroup>)value) { }

    private ConditionalUuidNullableGroup(
        OneOf<IfUuidNullableGroup, CoalesceUuidNullableGroup> input
    )
        : base(input) { }
}
