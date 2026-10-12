using OneOf;

namespace PureQL.CSharp.Model.GroupExpressions;

public sealed class DateNullableGroup : OneOfBase<DateGroup, ExactDateNullableGroup>
{
    public DateNullableGroup(DateGroup value)
        : this((OneOf<DateGroup, ExactDateNullableGroup>)value) { }

    public DateNullableGroup(ExactDateNullableGroup value)
        : this((OneOf<DateGroup, ExactDateNullableGroup>)value) { }

    private DateNullableGroup(OneOf<DateGroup, ExactDateNullableGroup> input)
        : base(input) { }
}
