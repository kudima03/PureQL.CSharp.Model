using OneOf;

namespace PureQL.CSharp.Model.GroupExpressions;

public sealed class AggregateBooleanGroup
    : OneOfBase<MinBooleanGroup, MaxBooleanGroup, AnyGroup, AllGroup>
{
    public AggregateBooleanGroup(MinBooleanGroup value)
        : this((OneOf<MinBooleanGroup, MaxBooleanGroup, AnyGroup, AllGroup>)value) { }

    public AggregateBooleanGroup(MaxBooleanGroup value)
        : this((OneOf<MinBooleanGroup, MaxBooleanGroup, AnyGroup, AllGroup>)value) { }

    public AggregateBooleanGroup(AnyGroup value)
        : this((OneOf<MinBooleanGroup, MaxBooleanGroup, AnyGroup, AllGroup>)value) { }

    public AggregateBooleanGroup(AllGroup value)
        : this((OneOf<MinBooleanGroup, MaxBooleanGroup, AnyGroup, AllGroup>)value) { }

    private AggregateBooleanGroup(
        OneOf<MinBooleanGroup, MaxBooleanGroup, AnyGroup, AllGroup> input
    )
        : base(input) { }
}
