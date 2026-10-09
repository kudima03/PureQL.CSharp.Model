using OneOf;

namespace PureQL.CSharp.Model.ProjectionExpressions;

public sealed class RoundingIntegerProjection
    : OneOfBase<FloorIntegerProjection, CeilingIntegerProjection, RoundIntegerProjection>
{
    public RoundingIntegerProjection(FloorIntegerProjection value)
        : this(
            (OneOf<
                FloorIntegerProjection,
                CeilingIntegerProjection,
                RoundIntegerProjection
            >)
                value
        )
    { }

    public RoundingIntegerProjection(CeilingIntegerProjection value)
        : this(
            (OneOf<
                FloorIntegerProjection,
                CeilingIntegerProjection,
                RoundIntegerProjection
            >)
                value
        )
    { }

    public RoundingIntegerProjection(RoundIntegerProjection value)
        : this(
            (OneOf<
                FloorIntegerProjection,
                CeilingIntegerProjection,
                RoundIntegerProjection
            >)
                value
        )
    { }

    private RoundingIntegerProjection(
        OneOf<
            FloorIntegerProjection,
            CeilingIntegerProjection,
            RoundIntegerProjection
        > input
    )
        : base(input) { }
}
