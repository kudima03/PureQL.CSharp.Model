using OneOf;

namespace PureQL.CSharp.Model.GroupExpressions;

public sealed class DifferenceDecimalGroup
    : OneOfBase<TimeDiffSecondsDecimalGroup, DatetimeDiffSecondsDecimalGroup>
{
    public DifferenceDecimalGroup(TimeDiffSecondsDecimalGroup value)
        : this((OneOf<TimeDiffSecondsDecimalGroup, DatetimeDiffSecondsDecimalGroup>)value)
    { }

    public DifferenceDecimalGroup(DatetimeDiffSecondsDecimalGroup value)
        : this((OneOf<TimeDiffSecondsDecimalGroup, DatetimeDiffSecondsDecimalGroup>)value)
    { }

    private DifferenceDecimalGroup(
        OneOf<TimeDiffSecondsDecimalGroup, DatetimeDiffSecondsDecimalGroup> input
    )
        : base(input) { }
}
