using OneOf;

namespace PureQL.CSharp.Model.GroupExpressions;

public sealed class AggregateTimeGroup
    : OneOfBase<AverageTimeGroup, MinTimeGroup, MaxTimeGroup>
{
    public AggregateTimeGroup(AverageTimeGroup value)
        : this((OneOf<AverageTimeGroup, MinTimeGroup, MaxTimeGroup>)value) { }

    public AggregateTimeGroup(MinTimeGroup value)
        : this((OneOf<AverageTimeGroup, MinTimeGroup, MaxTimeGroup>)value) { }

    public AggregateTimeGroup(MaxTimeGroup value)
        : this((OneOf<AverageTimeGroup, MinTimeGroup, MaxTimeGroup>)value) { }

    private AggregateTimeGroup(OneOf<AverageTimeGroup, MinTimeGroup, MaxTimeGroup> input)
        : base(input) { }
}
