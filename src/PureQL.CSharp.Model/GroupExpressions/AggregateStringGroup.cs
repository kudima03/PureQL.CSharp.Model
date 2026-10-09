using OneOf;

namespace PureQL.CSharp.Model.GroupExpressions;

public sealed class AggregateStringGroup : OneOfBase<MinStringGroup, MaxStringGroup>
{
    public AggregateStringGroup(MinStringGroup value)
        : this((OneOf<MinStringGroup, MaxStringGroup>)value) { }

    public AggregateStringGroup(MaxStringGroup value)
        : this((OneOf<MinStringGroup, MaxStringGroup>)value) { }

    private AggregateStringGroup(OneOf<MinStringGroup, MaxStringGroup> input)
        : base(input) { }
}
