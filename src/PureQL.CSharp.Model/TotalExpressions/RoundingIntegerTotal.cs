using OneOf;

namespace PureQL.CSharp.Model.TotalExpressions;

public sealed class RoundingIntegerTotal
    : OneOfBase<FloorIntegerTotal, CeilingIntegerTotal, RoundIntegerTotal>
{
    public RoundingIntegerTotal(FloorIntegerTotal value)
        : this((OneOf<FloorIntegerTotal, CeilingIntegerTotal, RoundIntegerTotal>)value)
    { }

    public RoundingIntegerTotal(CeilingIntegerTotal value)
        : this((OneOf<FloorIntegerTotal, CeilingIntegerTotal, RoundIntegerTotal>)value)
    { }

    public RoundingIntegerTotal(RoundIntegerTotal value)
        : this((OneOf<FloorIntegerTotal, CeilingIntegerTotal, RoundIntegerTotal>)value)
    { }

    private RoundingIntegerTotal(
        OneOf<FloorIntegerTotal, CeilingIntegerTotal, RoundIntegerTotal> input
    )
        : base(input) { }
}
