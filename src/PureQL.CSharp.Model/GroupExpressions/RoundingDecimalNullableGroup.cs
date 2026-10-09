using OneOf;

namespace PureQL.CSharp.Model.GroupExpressions;

public sealed class RoundingDecimalNullableGroup
    : OneOfBase<
        FloorIntegerNullableGroup,
        CeilingIntegerNullableGroup,
        RoundDecimalDigitsNullableGroup,
        RoundIntegerNullableGroup
    >
{
    public RoundingDecimalNullableGroup(FloorIntegerNullableGroup value)
        : this(
            (OneOf<
                FloorIntegerNullableGroup,
                CeilingIntegerNullableGroup,
                RoundDecimalDigitsNullableGroup,
                RoundIntegerNullableGroup
            >)
                value
        )
    { }

    public RoundingDecimalNullableGroup(CeilingIntegerNullableGroup value)
        : this(
            (OneOf<
                FloorIntegerNullableGroup,
                CeilingIntegerNullableGroup,
                RoundDecimalDigitsNullableGroup,
                RoundIntegerNullableGroup
            >)
                value
        )
    { }

    public RoundingDecimalNullableGroup(RoundDecimalDigitsNullableGroup value)
        : this(
            (OneOf<
                FloorIntegerNullableGroup,
                CeilingIntegerNullableGroup,
                RoundDecimalDigitsNullableGroup,
                RoundIntegerNullableGroup
            >)
                value
        )
    { }

    public RoundingDecimalNullableGroup(RoundIntegerNullableGroup value)
        : this(
            (OneOf<
                FloorIntegerNullableGroup,
                CeilingIntegerNullableGroup,
                RoundDecimalDigitsNullableGroup,
                RoundIntegerNullableGroup
            >)
                value
        )
    { }

    private RoundingDecimalNullableGroup(
        OneOf<
            FloorIntegerNullableGroup,
            CeilingIntegerNullableGroup,
            RoundDecimalDigitsNullableGroup,
            RoundIntegerNullableGroup
        > input
    )
        : base(input) { }
}
