using OneOf;

namespace PureQL.CSharp.Model.GroupExpressions;

public sealed class AggregateBooleanNullableGroup
    : OneOfBase<MinBooleanNullableGroup, MaxBooleanNullableGroup>
{
    public AggregateBooleanNullableGroup(MinBooleanNullableGroup value)
        : this((OneOf<MinBooleanNullableGroup, MaxBooleanNullableGroup>)value) { }

    public AggregateBooleanNullableGroup(MaxBooleanNullableGroup value)
        : this((OneOf<MinBooleanNullableGroup, MaxBooleanNullableGroup>)value) { }

    private AggregateBooleanNullableGroup(
        OneOf<MinBooleanNullableGroup, MaxBooleanNullableGroup> input
    )
        : base(input) { }
}
