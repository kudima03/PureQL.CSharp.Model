using OneOf;

namespace PureQL.CSharp.Model.GroupExpressions;

public sealed class AggregateDateNullableGroup
    : OneOfBase<AverageDateNullableGroup, MinDateNullableGroup, MaxDateNullableGroup>
{
    public AggregateDateNullableGroup(AverageDateNullableGroup value)
        : this(
            (OneOf<AverageDateNullableGroup, MinDateNullableGroup, MaxDateNullableGroup>)
                value
        )
    { }

    public AggregateDateNullableGroup(MinDateNullableGroup value)
        : this(
            (OneOf<AverageDateNullableGroup, MinDateNullableGroup, MaxDateNullableGroup>)
                value
        )
    { }

    public AggregateDateNullableGroup(MaxDateNullableGroup value)
        : this(
            (OneOf<AverageDateNullableGroup, MinDateNullableGroup, MaxDateNullableGroup>)
                value
        )
    { }

    private AggregateDateNullableGroup(
        OneOf<AverageDateNullableGroup, MinDateNullableGroup, MaxDateNullableGroup> input
    )
        : base(input) { }
}
