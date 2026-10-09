using OneOf;

namespace PureQL.CSharp.Model.GroupExpressions;

public sealed class RoundingIntegerGroup
    : OneOfBase<FloorIntegerGroup, CeilingIntegerGroup, RoundIntegerGroup>
{
    public RoundingIntegerGroup(FloorIntegerGroup value)
        : this((OneOf<FloorIntegerGroup, CeilingIntegerGroup, RoundIntegerGroup>)value)
    { }

    public RoundingIntegerGroup(CeilingIntegerGroup value)
        : this((OneOf<FloorIntegerGroup, CeilingIntegerGroup, RoundIntegerGroup>)value)
    { }

    public RoundingIntegerGroup(RoundIntegerGroup value)
        : this((OneOf<FloorIntegerGroup, CeilingIntegerGroup, RoundIntegerGroup>)value)
    { }

    private RoundingIntegerGroup(
        OneOf<FloorIntegerGroup, CeilingIntegerGroup, RoundIntegerGroup> input
    )
        : base(input) { }
}
