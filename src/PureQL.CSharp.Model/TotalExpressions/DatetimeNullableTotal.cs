using OneOf;

namespace PureQL.CSharp.Model.TotalExpressions;

public sealed class DatetimeNullableTotal
    : OneOfBase<DatetimeTotal, ExactDatetimeNullableTotal>
{
    public DatetimeNullableTotal(DatetimeTotal value)
        : this((OneOf<DatetimeTotal, ExactDatetimeNullableTotal>)value) { }

    public DatetimeNullableTotal(ExactDatetimeNullableTotal value)
        : this((OneOf<DatetimeTotal, ExactDatetimeNullableTotal>)value) { }

    private DatetimeNullableTotal(OneOf<DatetimeTotal, ExactDatetimeNullableTotal> input)
        : base(input) { }
}
