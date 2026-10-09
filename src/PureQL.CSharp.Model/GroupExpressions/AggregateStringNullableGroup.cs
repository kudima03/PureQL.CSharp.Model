using OneOf;

namespace PureQL.CSharp.Model.GroupExpressions;

public sealed class AggregateStringNullableGroup
    : OneOfBase<MinStringNullableGroup, MaxStringNullableGroup>
{
    public AggregateStringNullableGroup(MinStringNullableGroup value)
        : this((OneOf<MinStringNullableGroup, MaxStringNullableGroup>)value) { }

    public AggregateStringNullableGroup(MaxStringNullableGroup value)
        : this((OneOf<MinStringNullableGroup, MaxStringNullableGroup>)value) { }

    private AggregateStringNullableGroup(
        OneOf<MinStringNullableGroup, MaxStringNullableGroup> input
    )
        : base(input) { }
}
