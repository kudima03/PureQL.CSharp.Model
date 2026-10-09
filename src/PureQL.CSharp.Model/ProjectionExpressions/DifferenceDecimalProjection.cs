using OneOf;

namespace PureQL.CSharp.Model.ProjectionExpressions;

public sealed class DifferenceDecimalProjection
    : OneOfBase<
        DateDiffDaysIntegerProjection,
        TimeDiffSecondsDecimalProjection,
        DatetimeDiffSecondsDecimalProjection
    >
{
    public DifferenceDecimalProjection(DateDiffDaysIntegerProjection value)
        : this(
            (OneOf<
                DateDiffDaysIntegerProjection,
                TimeDiffSecondsDecimalProjection,
                DatetimeDiffSecondsDecimalProjection
            >)
                value
        )
    { }

    public DifferenceDecimalProjection(TimeDiffSecondsDecimalProjection value)
        : this(
            (OneOf<
                DateDiffDaysIntegerProjection,
                TimeDiffSecondsDecimalProjection,
                DatetimeDiffSecondsDecimalProjection
            >)
                value
        )
    { }

    public DifferenceDecimalProjection(DatetimeDiffSecondsDecimalProjection value)
        : this(
            (OneOf<
                DateDiffDaysIntegerProjection,
                TimeDiffSecondsDecimalProjection,
                DatetimeDiffSecondsDecimalProjection
            >)
                value
        )
    { }

    private DifferenceDecimalProjection(
        OneOf<
            DateDiffDaysIntegerProjection,
            TimeDiffSecondsDecimalProjection,
            DatetimeDiffSecondsDecimalProjection
        > input
    )
        : base(input) { }
}
