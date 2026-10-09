using OneOf;

namespace PureQL.CSharp.Model.ProjectionExpressions;

public sealed class RoundingDecimalProjection
    : OneOfBase<
        FloorIntegerProjection,
        CeilingIntegerProjection,
        RoundDecimalDigitsProjection,
        RoundIntegerProjection
    >
{
    public RoundingDecimalProjection(FloorIntegerProjection value)
        : this(
            (OneOf<
                FloorIntegerProjection,
                CeilingIntegerProjection,
                RoundDecimalDigitsProjection,
                RoundIntegerProjection
            >)
                value
        )
    { }

    public RoundingDecimalProjection(CeilingIntegerProjection value)
        : this(
            (OneOf<
                FloorIntegerProjection,
                CeilingIntegerProjection,
                RoundDecimalDigitsProjection,
                RoundIntegerProjection
            >)
                value
        )
    { }

    public RoundingDecimalProjection(RoundDecimalDigitsProjection value)
        : this(
            (OneOf<
                FloorIntegerProjection,
                CeilingIntegerProjection,
                RoundDecimalDigitsProjection,
                RoundIntegerProjection
            >)
                value
        )
    { }

    public RoundingDecimalProjection(RoundIntegerProjection value)
        : this(
            (OneOf<
                FloorIntegerProjection,
                CeilingIntegerProjection,
                RoundDecimalDigitsProjection,
                RoundIntegerProjection
            >)
                value
        )
    { }

    private RoundingDecimalProjection(
        OneOf<
            FloorIntegerProjection,
            CeilingIntegerProjection,
            RoundDecimalDigitsProjection,
            RoundIntegerProjection
        > input
    )
        : base(input) { }
}
