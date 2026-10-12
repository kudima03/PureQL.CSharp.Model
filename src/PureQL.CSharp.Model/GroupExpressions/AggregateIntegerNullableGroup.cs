using OneOf;

namespace PureQL.CSharp.Model.GroupExpressions;

public sealed class AggregateIntegerNullableGroup
    : OneOfBase<MinIntegerNullableGroup, MaxIntegerNullableGroup>
{
    public AggregateIntegerNullableGroup(MinIntegerNullableGroup value)
        : this((OneOf<MinIntegerNullableGroup, MaxIntegerNullableGroup>)value) { }

    public AggregateIntegerNullableGroup(MaxIntegerNullableGroup value)
        : this((OneOf<MinIntegerNullableGroup, MaxIntegerNullableGroup>)value) { }

    private AggregateIntegerNullableGroup(
        OneOf<MinIntegerNullableGroup, MaxIntegerNullableGroup> input
    )
        : base(input) { }
}
