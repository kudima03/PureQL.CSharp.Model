using OneOf;

namespace PureQL.CSharp.Model.RowExpressions;

public sealed class DateNullableRow : OneOfBase<DateRow, ExactDateNullableRow>
{
    public DateNullableRow(DateRow value)
        : this((OneOf<DateRow, ExactDateNullableRow>)value) { }

    public DateNullableRow(ExactDateNullableRow value)
        : this((OneOf<DateRow, ExactDateNullableRow>)value) { }

    private DateNullableRow(OneOf<DateRow, ExactDateNullableRow> input)
        : base(input) { }
}
