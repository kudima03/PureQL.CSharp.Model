using OneOf;

namespace PureQL.CSharp.Model.GroupExpressions;

public sealed class AggregateDateGroup
    : OneOfBase<AverageDateGroup, MinDateGroup, MaxDateGroup>
{
    public AggregateDateGroup(AverageDateGroup value)
        : this((OneOf<AverageDateGroup, MinDateGroup, MaxDateGroup>)value) { }

    public AggregateDateGroup(MinDateGroup value)
        : this((OneOf<AverageDateGroup, MinDateGroup, MaxDateGroup>)value) { }

    public AggregateDateGroup(MaxDateGroup value)
        : this((OneOf<AverageDateGroup, MinDateGroup, MaxDateGroup>)value) { }

    private AggregateDateGroup(OneOf<AverageDateGroup, MinDateGroup, MaxDateGroup> input)
        : base(input) { }
}
