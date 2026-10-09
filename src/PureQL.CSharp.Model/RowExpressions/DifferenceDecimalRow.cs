using OneOf;

namespace PureQL.CSharp.Model.RowExpressions;

public sealed class DifferenceDecimalRow
    : OneOfBase<
        DateDiffDaysIntegerRow,
        TimeDiffSecondsDecimalRow,
        DatetimeDiffSecondsDecimalRow
    >
{
    public DifferenceDecimalRow(DateDiffDaysIntegerRow value)
        : this(
            (OneOf<
                DateDiffDaysIntegerRow,
                TimeDiffSecondsDecimalRow,
                DatetimeDiffSecondsDecimalRow
            >)
                value
        )
    { }

    public DifferenceDecimalRow(TimeDiffSecondsDecimalRow value)
        : this(
            (OneOf<
                DateDiffDaysIntegerRow,
                TimeDiffSecondsDecimalRow,
                DatetimeDiffSecondsDecimalRow
            >)
                value
        )
    { }

    public DifferenceDecimalRow(DatetimeDiffSecondsDecimalRow value)
        : this(
            (OneOf<
                DateDiffDaysIntegerRow,
                TimeDiffSecondsDecimalRow,
                DatetimeDiffSecondsDecimalRow
            >)
                value
        )
    { }

    private DifferenceDecimalRow(
        OneOf<
            DateDiffDaysIntegerRow,
            TimeDiffSecondsDecimalRow,
            DatetimeDiffSecondsDecimalRow
        > input
    )
        : base(input) { }
}
