using OneOf;

namespace PureQL.CSharp.Model.ProjectionExpressions;

public sealed class RoundingDecimalNullableProjection
    : OneOfBase<
        FloorIntegerNullableProjection,
        CeilingIntegerNullableProjection,
        RoundDecimalDigitsNullableProjection,
        RoundIntegerNullableProjection
    >
{
    public RoundingDecimalNullableProjection(FloorIntegerNullableProjection value)
        : this(
            (OneOf<
                FloorIntegerNullableProjection,
                CeilingIntegerNullableProjection,
                RoundDecimalDigitsNullableProjection,
                RoundIntegerNullableProjection
            >)
                value
        )
    { }

    public RoundingDecimalNullableProjection(CeilingIntegerNullableProjection value)
        : this(
            (OneOf<
                FloorIntegerNullableProjection,
                CeilingIntegerNullableProjection,
                RoundDecimalDigitsNullableProjection,
                RoundIntegerNullableProjection
            >)
                value
        )
    { }

    public RoundingDecimalNullableProjection(RoundDecimalDigitsNullableProjection value)
        : this(
            (OneOf<
                FloorIntegerNullableProjection,
                CeilingIntegerNullableProjection,
                RoundDecimalDigitsNullableProjection,
                RoundIntegerNullableProjection
            >)
                value
        )
    { }

    public RoundingDecimalNullableProjection(RoundIntegerNullableProjection value)
        : this(
            (OneOf<
                FloorIntegerNullableProjection,
                CeilingIntegerNullableProjection,
                RoundDecimalDigitsNullableProjection,
                RoundIntegerNullableProjection
            >)
                value
        )
    { }

    private RoundingDecimalNullableProjection(
        OneOf<
            FloorIntegerNullableProjection,
            CeilingIntegerNullableProjection,
            RoundDecimalDigitsNullableProjection,
            RoundIntegerNullableProjection
        > input
    )
        : base(input) { }
}
