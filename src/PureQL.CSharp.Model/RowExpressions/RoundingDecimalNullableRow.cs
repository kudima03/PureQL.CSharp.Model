using OneOf;

namespace PureQL.CSharp.Model.RowExpressions;

public sealed class RoundingDecimalNullableRow
    : OneOfBase<
        FloorIntegerNullableRow,
        CeilingIntegerNullableRow,
        RoundDecimalDigitsNullableRow,
        RoundIntegerNullableRow
    >
{
    public RoundingDecimalNullableRow(FloorIntegerNullableRow value)
        : this(
            (OneOf<
                FloorIntegerNullableRow,
                CeilingIntegerNullableRow,
                RoundDecimalDigitsNullableRow,
                RoundIntegerNullableRow
            >)
                value
        )
    { }

    public RoundingDecimalNullableRow(CeilingIntegerNullableRow value)
        : this(
            (OneOf<
                FloorIntegerNullableRow,
                CeilingIntegerNullableRow,
                RoundDecimalDigitsNullableRow,
                RoundIntegerNullableRow
            >)
                value
        )
    { }

    public RoundingDecimalNullableRow(RoundDecimalDigitsNullableRow value)
        : this(
            (OneOf<
                FloorIntegerNullableRow,
                CeilingIntegerNullableRow,
                RoundDecimalDigitsNullableRow,
                RoundIntegerNullableRow
            >)
                value
        )
    { }

    public RoundingDecimalNullableRow(RoundIntegerNullableRow value)
        : this(
            (OneOf<
                FloorIntegerNullableRow,
                CeilingIntegerNullableRow,
                RoundDecimalDigitsNullableRow,
                RoundIntegerNullableRow
            >)
                value
        )
    { }

    private RoundingDecimalNullableRow(
        OneOf<
            FloorIntegerNullableRow,
            CeilingIntegerNullableRow,
            RoundDecimalDigitsNullableRow,
            RoundIntegerNullableRow
        > input
    )
        : base(input) { }
}
