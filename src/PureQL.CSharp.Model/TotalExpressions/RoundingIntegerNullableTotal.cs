using OneOf;

namespace PureQL.CSharp.Model.TotalExpressions;

public sealed class RoundingIntegerNullableTotal
    : OneOfBase<
        FloorIntegerNullableTotal,
        CeilingIntegerNullableTotal,
        RoundIntegerNullableTotal
    >
{
    public RoundingIntegerNullableTotal(FloorIntegerNullableTotal value)
        : this(
            (OneOf<
                FloorIntegerNullableTotal,
                CeilingIntegerNullableTotal,
                RoundIntegerNullableTotal
            >)
                value
        )
    { }

    public RoundingIntegerNullableTotal(CeilingIntegerNullableTotal value)
        : this(
            (OneOf<
                FloorIntegerNullableTotal,
                CeilingIntegerNullableTotal,
                RoundIntegerNullableTotal
            >)
                value
        )
    { }

    public RoundingIntegerNullableTotal(RoundIntegerNullableTotal value)
        : this(
            (OneOf<
                FloorIntegerNullableTotal,
                CeilingIntegerNullableTotal,
                RoundIntegerNullableTotal
            >)
                value
        )
    { }

    private RoundingIntegerNullableTotal(
        OneOf<
            FloorIntegerNullableTotal,
            CeilingIntegerNullableTotal,
            RoundIntegerNullableTotal
        > input
    )
        : base(input) { }
}
