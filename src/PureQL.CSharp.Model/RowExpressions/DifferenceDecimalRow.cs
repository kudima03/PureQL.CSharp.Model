using OneOf;

namespace PureQL.CSharp.Model.RowExpressions;

public sealed class DifferenceDecimalRow
    : OneOfBase<TimeDiffSecondsDecimalRow, DatetimeDiffSecondsDecimalRow>
{
    public DifferenceDecimalRow(TimeDiffSecondsDecimalRow value)
        : this((OneOf<TimeDiffSecondsDecimalRow, DatetimeDiffSecondsDecimalRow>)value) { }

    public DifferenceDecimalRow(DatetimeDiffSecondsDecimalRow value)
        : this((OneOf<TimeDiffSecondsDecimalRow, DatetimeDiffSecondsDecimalRow>)value) { }

    private DifferenceDecimalRow(
        OneOf<TimeDiffSecondsDecimalRow, DatetimeDiffSecondsDecimalRow> input
    )
        : base(input) { }
}
