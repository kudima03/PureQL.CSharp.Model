using OneOf;

namespace PureQL.CSharp.Model.GroupExpressions;

public sealed class AggregateDatetimeGroup
    : OneOfBase<AverageDatetimeGroup, MinDatetimeGroup, MaxDatetimeGroup>
{
    public AggregateDatetimeGroup(AverageDatetimeGroup value)
        : this((OneOf<AverageDatetimeGroup, MinDatetimeGroup, MaxDatetimeGroup>)value) { }

    public AggregateDatetimeGroup(MinDatetimeGroup value)
        : this((OneOf<AverageDatetimeGroup, MinDatetimeGroup, MaxDatetimeGroup>)value) { }

    public AggregateDatetimeGroup(MaxDatetimeGroup value)
        : this((OneOf<AverageDatetimeGroup, MinDatetimeGroup, MaxDatetimeGroup>)value) { }

    private AggregateDatetimeGroup(
        OneOf<AverageDatetimeGroup, MinDatetimeGroup, MaxDatetimeGroup> input
    )
        : base(input) { }
}
