using OneOf;

namespace PureQL.CSharp.Model.TotalExpressions;

public sealed class DateNullableTotal : OneOfBase<DateTotal, ExactDateNullableTotal>
{
    public DateNullableTotal(DateTotal value)
        : this((OneOf<DateTotal, ExactDateNullableTotal>)value) { }

    public DateNullableTotal(ExactDateNullableTotal value)
        : this((OneOf<DateTotal, ExactDateNullableTotal>)value) { }

    private DateNullableTotal(OneOf<DateTotal, ExactDateNullableTotal> input)
        : base(input) { }
}
