using OneOf;

namespace PureQL.CSharp.Model.RowExpressions;

public sealed class DifferenceDecimalNullableRow
    : OneOfBase<TimeDiffSecondsDecimalNullableRow, DatetimeDiffSecondsDecimalNullableRow>
{
    public DifferenceDecimalNullableRow(TimeDiffSecondsDecimalNullableRow value)
        : this(
            (OneOf<
                TimeDiffSecondsDecimalNullableRow,
                DatetimeDiffSecondsDecimalNullableRow
            >)
                value
        )
    { }

    public DifferenceDecimalNullableRow(DatetimeDiffSecondsDecimalNullableRow value)
        : this(
            (OneOf<
                TimeDiffSecondsDecimalNullableRow,
                DatetimeDiffSecondsDecimalNullableRow
            >)
                value
        )
    { }

    private DifferenceDecimalNullableRow(
        OneOf<
            TimeDiffSecondsDecimalNullableRow,
            DatetimeDiffSecondsDecimalNullableRow
        > input
    )
        : base(input) { }
}
