using OneOf;

namespace PureQL.CSharp.Model.RowExpressions;

public sealed class DatetimeNullableRow : OneOfBase<DatetimeRow, ExactDatetimeNullableRow>
{
    public DatetimeNullableRow(DatetimeRow value)
        : this((OneOf<DatetimeRow, ExactDatetimeNullableRow>)value) { }

    public DatetimeNullableRow(ExactDatetimeNullableRow value)
        : this((OneOf<DatetimeRow, ExactDatetimeNullableRow>)value) { }

    private DatetimeNullableRow(OneOf<DatetimeRow, ExactDatetimeNullableRow> input)
        : base(input) { }
}
