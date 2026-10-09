using OneOf;

namespace PureQL.CSharp.Model.GroupExpressions;

public sealed class DifferenceDecimalNullableGroup
    : OneOfBase<
        DateDiffDaysIntegerNullableGroup,
        TimeDiffSecondsDecimalNullableGroup,
        DatetimeDiffSecondsDecimalNullableGroup
    >
{
    public DifferenceDecimalNullableGroup(DateDiffDaysIntegerNullableGroup value)
        : this(
            (OneOf<
                DateDiffDaysIntegerNullableGroup,
                TimeDiffSecondsDecimalNullableGroup,
                DatetimeDiffSecondsDecimalNullableGroup
            >)
                value
        )
    { }

    public DifferenceDecimalNullableGroup(TimeDiffSecondsDecimalNullableGroup value)
        : this(
            (OneOf<
                DateDiffDaysIntegerNullableGroup,
                TimeDiffSecondsDecimalNullableGroup,
                DatetimeDiffSecondsDecimalNullableGroup
            >)
                value
        )
    { }

    public DifferenceDecimalNullableGroup(DatetimeDiffSecondsDecimalNullableGroup value)
        : this(
            (OneOf<
                DateDiffDaysIntegerNullableGroup,
                TimeDiffSecondsDecimalNullableGroup,
                DatetimeDiffSecondsDecimalNullableGroup
            >)
                value
        )
    { }

    private DifferenceDecimalNullableGroup(
        OneOf<
            DateDiffDaysIntegerNullableGroup,
            TimeDiffSecondsDecimalNullableGroup,
            DatetimeDiffSecondsDecimalNullableGroup
        > input
    )
        : base(input) { }
}
