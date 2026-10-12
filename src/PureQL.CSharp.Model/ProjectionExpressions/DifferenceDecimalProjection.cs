using OneOf;

namespace PureQL.CSharp.Model.ProjectionExpressions;

public sealed class DifferenceDecimalProjection
    : OneOfBase<TimeDiffSecondsDecimalProjection, DatetimeDiffSecondsDecimalProjection>
{
    public DifferenceDecimalProjection(TimeDiffSecondsDecimalProjection value)
        : this(
            (OneOf<
                TimeDiffSecondsDecimalProjection,
                DatetimeDiffSecondsDecimalProjection
            >)
                value
        )
    { }

    public DifferenceDecimalProjection(DatetimeDiffSecondsDecimalProjection value)
        : this(
            (OneOf<
                TimeDiffSecondsDecimalProjection,
                DatetimeDiffSecondsDecimalProjection
            >)
                value
        )
    { }

    private DifferenceDecimalProjection(
        OneOf<
            TimeDiffSecondsDecimalProjection,
            DatetimeDiffSecondsDecimalProjection
        > input
    )
        : base(input) { }
}
