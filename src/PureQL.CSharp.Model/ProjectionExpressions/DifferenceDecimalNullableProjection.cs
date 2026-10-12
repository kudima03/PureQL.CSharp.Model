using OneOf;

namespace PureQL.CSharp.Model.ProjectionExpressions;

public sealed class DifferenceDecimalNullableProjection
    : OneOfBase<
        TimeDiffSecondsDecimalNullableProjection,
        DatetimeDiffSecondsDecimalNullableProjection
    >
{
    public DifferenceDecimalNullableProjection(
        TimeDiffSecondsDecimalNullableProjection value
    )
        : this(
            (OneOf<
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
                TimeDiffSecondsDecimalNullableProjection,
                DatetimeDiffSecondsDecimalNullableProjection
            >)
                value
        )
    { }

    private DifferenceDecimalNullableProjection(
        OneOf<
            TimeDiffSecondsDecimalNullableProjection,
            DatetimeDiffSecondsDecimalNullableProjection
        > input
    )
        : base(input) { }
}
