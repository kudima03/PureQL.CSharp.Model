using OneOf;

namespace PureQL.CSharp.Model.GroupExpressions;

public sealed class DifferenceDecimalGroup
    : OneOfBase<
        DateDiffDaysIntegerGroup,
        TimeDiffSecondsDecimalGroup,
        DatetimeDiffSecondsDecimalGroup
    >
{
    public DifferenceDecimalGroup(DateDiffDaysIntegerGroup value)
        : this(
            (OneOf<
                DateDiffDaysIntegerGroup,
                TimeDiffSecondsDecimalGroup,
                DatetimeDiffSecondsDecimalGroup
            >)
                value
        )
    { }

    public DifferenceDecimalGroup(TimeDiffSecondsDecimalGroup value)
        : this(
            (OneOf<
                DateDiffDaysIntegerGroup,
                TimeDiffSecondsDecimalGroup,
                DatetimeDiffSecondsDecimalGroup
            >)
                value
        )
    { }

    public DifferenceDecimalGroup(DatetimeDiffSecondsDecimalGroup value)
        : this(
            (OneOf<
                DateDiffDaysIntegerGroup,
                TimeDiffSecondsDecimalGroup,
                DatetimeDiffSecondsDecimalGroup
            >)
                value
        )
    { }

    private DifferenceDecimalGroup(
        OneOf<
            DateDiffDaysIntegerGroup,
            TimeDiffSecondsDecimalGroup,
            DatetimeDiffSecondsDecimalGroup
        > input
    )
        : base(input) { }
}
