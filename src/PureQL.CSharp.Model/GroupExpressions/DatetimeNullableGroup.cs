using OneOf;

namespace PureQL.CSharp.Model.GroupExpressions;

public sealed class DatetimeNullableGroup
    : OneOfBase<DatetimeGroup, ExactDatetimeNullableGroup>
{
    public DatetimeNullableGroup(DatetimeGroup value)
        : this((OneOf<DatetimeGroup, ExactDatetimeNullableGroup>)value) { }

    public DatetimeNullableGroup(ExactDatetimeNullableGroup value)
        : this((OneOf<DatetimeGroup, ExactDatetimeNullableGroup>)value) { }

    private DatetimeNullableGroup(OneOf<DatetimeGroup, ExactDatetimeNullableGroup> input)
        : base(input) { }
}
