using OneOf;

namespace PureQL.CSharp.Model.ProjectionExpressions;

public sealed class RoundingIntegerNullableProjection
    : OneOfBase<
        FloorIntegerNullableProjection,
        CeilingIntegerNullableProjection,
        RoundIntegerNullableProjection
    >
{
    public RoundingIntegerNullableProjection(FloorIntegerNullableProjection value)
        : this(
            (OneOf<
                FloorIntegerNullableProjection,
                CeilingIntegerNullableProjection,
                RoundIntegerNullableProjection
            >)
                value
        )
    { }

    public RoundingIntegerNullableProjection(CeilingIntegerNullableProjection value)
        : this(
            (OneOf<
                FloorIntegerNullableProjection,
                CeilingIntegerNullableProjection,
                RoundIntegerNullableProjection
            >)
                value
        )
    { }

    public RoundingIntegerNullableProjection(RoundIntegerNullableProjection value)
        : this(
            (OneOf<
                FloorIntegerNullableProjection,
                CeilingIntegerNullableProjection,
                RoundIntegerNullableProjection
            >)
                value
        )
    { }

    private RoundingIntegerNullableProjection(
        OneOf<
            FloorIntegerNullableProjection,
            CeilingIntegerNullableProjection,
            RoundIntegerNullableProjection
        > input
    )
        : base(input) { }
}
