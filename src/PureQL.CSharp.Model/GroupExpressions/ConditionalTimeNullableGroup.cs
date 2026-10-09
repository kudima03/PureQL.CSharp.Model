using OneOf;

namespace PureQL.CSharp.Model.GroupExpressions;

public sealed class ConditionalTimeNullableGroup
    : OneOfBase<IfTimeNullableGroup, CoalesceTimeNullableGroup>
{
    public ConditionalTimeNullableGroup(IfTimeNullableGroup value)
        : this((OneOf<IfTimeNullableGroup, CoalesceTimeNullableGroup>)value) { }

    public ConditionalTimeNullableGroup(CoalesceTimeNullableGroup value)
        : this((OneOf<IfTimeNullableGroup, CoalesceTimeNullableGroup>)value) { }

    private ConditionalTimeNullableGroup(
        OneOf<IfTimeNullableGroup, CoalesceTimeNullableGroup> input
    )
        : base(input) { }
}
