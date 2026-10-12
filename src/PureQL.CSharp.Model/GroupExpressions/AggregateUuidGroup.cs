using OneOf;

namespace PureQL.CSharp.Model.GroupExpressions;

public sealed class AggregateUuidGroup : OneOfBase<MinUuidGroup, MaxUuidGroup>
{
    public AggregateUuidGroup(MinUuidGroup value)
        : this((OneOf<MinUuidGroup, MaxUuidGroup>)value) { }

    public AggregateUuidGroup(MaxUuidGroup value)
        : this((OneOf<MinUuidGroup, MaxUuidGroup>)value) { }

    private AggregateUuidGroup(OneOf<MinUuidGroup, MaxUuidGroup> input)
        : base(input) { }
}
