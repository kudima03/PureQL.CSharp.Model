using OneOf;

namespace PureQL.CSharp.Model.GroupExpressions;

public sealed class DifferenceDecimalNullableGroup
    : OneOfBase<
        TimeDiffSecondsDecimalNullableGroup,
        DatetimeDiffSecondsDecimalNullableGroup
    >
{
    public DifferenceDecimalNullableGroup(TimeDiffSecondsDecimalNullableGroup value)
        : this(
            (OneOf<
                TimeDiffSecondsDecimalNullableGroup,
                DatetimeDiffSecondsDecimalNullableGroup
            >)
                value
        )
    { }

    public DifferenceDecimalNullableGroup(DatetimeDiffSecondsDecimalNullableGroup value)
        : this(
            (OneOf<
                TimeDiffSecondsDecimalNullableGroup,
                DatetimeDiffSecondsDecimalNullableGroup
            >)
                value
        )
    { }

    private DifferenceDecimalNullableGroup(
        OneOf<
            TimeDiffSecondsDecimalNullableGroup,
            DatetimeDiffSecondsDecimalNullableGroup
        > input
    )
        : base(input) { }
}
