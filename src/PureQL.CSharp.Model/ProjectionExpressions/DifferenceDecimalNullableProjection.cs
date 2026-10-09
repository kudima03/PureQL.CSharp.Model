using OneOf;

namespace PureQL.CSharp.Model.ProjectionExpressions;

public sealed class DifferenceDecimalNullableProjection
    : OneOfBase<
        DateDiffDaysIntegerNullableProjection,
        TimeDiffSecondsDecimalNullableProjection,
        DatetimeDiffSecondsDecimalNullableProjection
    >
{
    public DifferenceDecimalNullableProjection(
        DateDiffDaysIntegerNullableProjection value
    )
        : this(
            (OneOf<
                DateDiffDaysIntegerNullableProjection,
                TimeDiffSecondsDecimalNullableProjection,
                DatetimeDiffSecondsDecimalNullableProjection
            >)
                value
        )
    { }

    public DifferenceDecimalNullableProjection(
        TimeDiffSecondsDecimalNullableProjection value
    )
        : this(
            (OneOf<
                DateDiffDaysIntegerNullableProjection,
                TimeDiffSecondsDecimalNullableProjection,
                DatetimeDiffSecondsDecimalNullableProjection
            >)
                value
        )
    { }

    public DifferenceDecimalNullableProjection(
        DatetimeDiffSecondsDecimalNullableProjection value
    )
        : this(
            (OneOf<
                DateDiffDaysIntegerNullableProjection,
                TimeDiffSecondsDecimalNullableProjection,
                DatetimeDiffSecondsDecimalNullableProjection
            >)
                value
        )
    { }

    private DifferenceDecimalNullableProjection(
        OneOf<
            DateDiffDaysIntegerNullableProjection,
            TimeDiffSecondsDecimalNullableProjection,
            DatetimeDiffSecondsDecimalNullableProjection
        > input
    )
        : base(input) { }
}
