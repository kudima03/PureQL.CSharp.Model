using OneOf;

namespace PureQL.CSharp.Model.TotalExpressions;

public sealed class DifferenceDecimalNullableTotal
    : OneOfBase<
        TimeDiffSecondsDecimalNullableTotal,
        DatetimeDiffSecondsDecimalNullableTotal
    >
{
    public DifferenceDecimalNullableTotal(TimeDiffSecondsDecimalNullableTotal value)
        : this(
            (OneOf<
                TimeDiffSecondsDecimalNullableTotal,
                DatetimeDiffSecondsDecimalNullableTotal
            >)
                value
        )
    { }

    public DifferenceDecimalNullableTotal(DatetimeDiffSecondsDecimalNullableTotal value)
        : this(
            (OneOf<
                TimeDiffSecondsDecimalNullableTotal,
                DatetimeDiffSecondsDecimalNullableTotal
            >)
                value
        )
    { }

    private DifferenceDecimalNullableTotal(
        OneOf<
            TimeDiffSecondsDecimalNullableTotal,
            DatetimeDiffSecondsDecimalNullableTotal
        > input
    )
        : base(input) { }
}
