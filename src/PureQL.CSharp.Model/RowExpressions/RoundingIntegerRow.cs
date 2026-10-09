using OneOf;

namespace PureQL.CSharp.Model.RowExpressions;

public sealed class RoundingIntegerRow
    : OneOfBase<FloorIntegerRow, CeilingIntegerRow, RoundIntegerRow>
{
    public RoundingIntegerRow(FloorIntegerRow value)
        : this((OneOf<FloorIntegerRow, CeilingIntegerRow, RoundIntegerRow>)value) { }

    public RoundingIntegerRow(CeilingIntegerRow value)
        : this((OneOf<FloorIntegerRow, CeilingIntegerRow, RoundIntegerRow>)value) { }

    public RoundingIntegerRow(RoundIntegerRow value)
        : this((OneOf<FloorIntegerRow, CeilingIntegerRow, RoundIntegerRow>)value) { }

    private RoundingIntegerRow(
        OneOf<FloorIntegerRow, CeilingIntegerRow, RoundIntegerRow> input
    )
        : base(input) { }
}
