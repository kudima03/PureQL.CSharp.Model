using OneOf;

namespace PureQL.CSharp.Model.RowExpressions;

public sealed class TimeNullableRow : OneOfBase<TimeRow, ExactTimeNullableRow>
{
    public TimeNullableRow(TimeRow value)
        : this((OneOf<TimeRow, ExactTimeNullableRow>)value) { }

    public TimeNullableRow(ExactTimeNullableRow value)
        : this((OneOf<TimeRow, ExactTimeNullableRow>)value) { }

    private TimeNullableRow(OneOf<TimeRow, ExactTimeNullableRow> input)
        : base(input) { }
}
