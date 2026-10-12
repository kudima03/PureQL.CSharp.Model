using OneOf;

namespace PureQL.CSharp.Model.GroupExpressions;

public sealed class AggregateUuidNullableGroup
    : OneOfBase<MinUuidNullableGroup, MaxUuidNullableGroup>
{
    public AggregateUuidNullableGroup(MinUuidNullableGroup value)
        : this((OneOf<MinUuidNullableGroup, MaxUuidNullableGroup>)value) { }

    public AggregateUuidNullableGroup(MaxUuidNullableGroup value)
        : this((OneOf<MinUuidNullableGroup, MaxUuidNullableGroup>)value) { }

    private AggregateUuidNullableGroup(
        OneOf<MinUuidNullableGroup, MaxUuidNullableGroup> input
    )
        : base(input) { }
}
