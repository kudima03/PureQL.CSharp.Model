using OneOf;

namespace PureQL.CSharp.Model.TotalExpressions;

public sealed class DifferenceDecimalTotal
    : OneOfBase<TimeDiffSecondsDecimalTotal, DatetimeDiffSecondsDecimalTotal>
{
    public DifferenceDecimalTotal(TimeDiffSecondsDecimalTotal value)
        : this((OneOf<TimeDiffSecondsDecimalTotal, DatetimeDiffSecondsDecimalTotal>)value)
    { }

    public DifferenceDecimalTotal(DatetimeDiffSecondsDecimalTotal value)
        : this((OneOf<TimeDiffSecondsDecimalTotal, DatetimeDiffSecondsDecimalTotal>)value)
    { }

    private DifferenceDecimalTotal(
        OneOf<TimeDiffSecondsDecimalTotal, DatetimeDiffSecondsDecimalTotal> input
    )
        : base(input) { }
}
