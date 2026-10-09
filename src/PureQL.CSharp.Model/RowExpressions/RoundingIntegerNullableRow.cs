using OneOf;

namespace PureQL.CSharp.Model.RowExpressions;

public sealed class RoundingIntegerNullableRow
    : OneOfBase<
        FloorIntegerNullableRow,
        CeilingIntegerNullableRow,
        RoundIntegerNullableRow
    >
{
    public RoundingIntegerNullableRow(FloorIntegerNullableRow value)
        : this(
            (OneOf<
                FloorIntegerNullableRow,
                CeilingIntegerNullableRow,
                RoundIntegerNullableRow
            >)
                value
        )
    { }

    public RoundingIntegerNullableRow(CeilingIntegerNullableRow value)
        : this(
            (OneOf<
                FloorIntegerNullableRow,
                CeilingIntegerNullableRow,
                RoundIntegerNullableRow
            >)
                value
        )
    { }

    public RoundingIntegerNullableRow(RoundIntegerNullableRow value)
        : this(
            (OneOf<
                FloorIntegerNullableRow,
                CeilingIntegerNullableRow,
                RoundIntegerNullableRow
            >)
                value
        )
    { }

    private RoundingIntegerNullableRow(
        OneOf<
            FloorIntegerNullableRow,
            CeilingIntegerNullableRow,
            RoundIntegerNullableRow
        > input
    )
        : base(input) { }
}
