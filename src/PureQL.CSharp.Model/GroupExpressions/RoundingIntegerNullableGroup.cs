using OneOf;

namespace PureQL.CSharp.Model.GroupExpressions;

public sealed class RoundingIntegerNullableGroup
    : OneOfBase<
        FloorIntegerNullableGroup,
        CeilingIntegerNullableGroup,
        RoundIntegerNullableGroup
    >
{
    public RoundingIntegerNullableGroup(FloorIntegerNullableGroup value)
        : this(
            (OneOf<
                FloorIntegerNullableGroup,
                CeilingIntegerNullableGroup,
                RoundIntegerNullableGroup
            >)
                value
        )
    { }

    public RoundingIntegerNullableGroup(CeilingIntegerNullableGroup value)
        : this(
            (OneOf<
                FloorIntegerNullableGroup,
                CeilingIntegerNullableGroup,
                RoundIntegerNullableGroup
            >)
                value
        )
    { }

    public RoundingIntegerNullableGroup(RoundIntegerNullableGroup value)
        : this(
            (OneOf<
                FloorIntegerNullableGroup,
                CeilingIntegerNullableGroup,
                RoundIntegerNullableGroup
            >)
                value
        )
    { }

    private RoundingIntegerNullableGroup(
        OneOf<
            FloorIntegerNullableGroup,
            CeilingIntegerNullableGroup,
            RoundIntegerNullableGroup
        > input
    )
        : base(input) { }
}
