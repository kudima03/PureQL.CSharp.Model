using OneOf;

namespace PureQL.CSharp.Model.GroupExpressions;

public sealed class TimeNullableGroup : OneOfBase<TimeGroup, ExactTimeNullableGroup>
{
    public TimeNullableGroup(TimeGroup value)
        : this((OneOf<TimeGroup, ExactTimeNullableGroup>)value) { }

    public TimeNullableGroup(ExactTimeNullableGroup value)
        : this((OneOf<TimeGroup, ExactTimeNullableGroup>)value) { }

    private TimeNullableGroup(OneOf<TimeGroup, ExactTimeNullableGroup> input)
        : base(input) { }
}
