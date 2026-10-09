using OneOf;

namespace PureQL.CSharp.Model.RowExpressions;

public sealed class RoundingDecimalRow
    : OneOfBase<
        FloorIntegerRow,
        CeilingIntegerRow,
        RoundDecimalDigitsRow,
        RoundIntegerRow
    >
{
    public RoundingDecimalRow(FloorIntegerRow value)
        : this(
            (OneOf<
                FloorIntegerRow,
                CeilingIntegerRow,
                RoundDecimalDigitsRow,
                RoundIntegerRow
            >)
                value
        )
    { }

    public RoundingDecimalRow(CeilingIntegerRow value)
        : this(
            (OneOf<
                FloorIntegerRow,
                CeilingIntegerRow,
                RoundDecimalDigitsRow,
                RoundIntegerRow
            >)
                value
        )
    { }

    public RoundingDecimalRow(RoundDecimalDigitsRow value)
        : this(
            (OneOf<
                FloorIntegerRow,
                CeilingIntegerRow,
                RoundDecimalDigitsRow,
                RoundIntegerRow
            >)
                value
        )
    { }

    public RoundingDecimalRow(RoundIntegerRow value)
        : this(
            (OneOf<
                FloorIntegerRow,
                CeilingIntegerRow,
                RoundDecimalDigitsRow,
                RoundIntegerRow
            >)
                value
        )
    { }

    private RoundingDecimalRow(
        OneOf<
            FloorIntegerRow,
            CeilingIntegerRow,
            RoundDecimalDigitsRow,
            RoundIntegerRow
        > input
    )
        : base(input) { }
}
