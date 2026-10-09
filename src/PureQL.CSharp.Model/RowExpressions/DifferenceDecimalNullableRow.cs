using OneOf;

namespace PureQL.CSharp.Model.RowExpressions;

public sealed class DifferenceDecimalNullableRow
    : OneOfBase<
        DateDiffDaysIntegerNullableRow,
        TimeDiffSecondsDecimalNullableRow,
        DatetimeDiffSecondsDecimalNullableRow
    >
{
    public DifferenceDecimalNullableRow(DateDiffDaysIntegerNullableRow value)
        : this(
            (OneOf<
                DateDiffDaysIntegerNullableRow,
                TimeDiffSecondsDecimalNullableRow,
                DatetimeDiffSecondsDecimalNullableRow
            >)
                value
        )
    { }

    public DifferenceDecimalNullableRow(TimeDiffSecondsDecimalNullableRow value)
        : this(
            (OneOf<
                DateDiffDaysIntegerNullableRow,
                TimeDiffSecondsDecimalNullableRow,
                DatetimeDiffSecondsDecimalNullableRow
            >)
                value
        )
    { }

    public DifferenceDecimalNullableRow(DatetimeDiffSecondsDecimalNullableRow value)
        : this(
            (OneOf<
                DateDiffDaysIntegerNullableRow,
                TimeDiffSecondsDecimalNullableRow,
                DatetimeDiffSecondsDecimalNullableRow
            >)
                value
        )
    { }

    private DifferenceDecimalNullableRow(
        OneOf<
            DateDiffDaysIntegerNullableRow,
            TimeDiffSecondsDecimalNullableRow,
            DatetimeDiffSecondsDecimalNullableRow
        > input
    )
        : base(input) { }
}
