using OneOf;

namespace PureQL.CSharp.Model.GroupExpressions;

public sealed class ConditionalDecimalNullableGroup
    : OneOfBase<IfDecimalNullableGroup, CoalesceDecimalNullableGroup>
{
    public ConditionalDecimalNullableGroup(IfDecimalNullableGroup value)
        : this((OneOf<IfDecimalNullableGroup, CoalesceDecimalNullableGroup>)value) { }

    public ConditionalDecimalNullableGroup(CoalesceDecimalNullableGroup value)
        : this((OneOf<IfDecimalNullableGroup, CoalesceDecimalNullableGroup>)value) { }

    private ConditionalDecimalNullableGroup(
        OneOf<IfDecimalNullableGroup, CoalesceDecimalNullableGroup> input
    )
        : base(input) { }
}
