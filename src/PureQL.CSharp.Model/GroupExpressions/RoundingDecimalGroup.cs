using OneOf;

namespace PureQL.CSharp.Model.GroupExpressions;

public sealed class RoundingDecimalGroup
    : OneOfBase<
        FloorIntegerGroup,
        CeilingIntegerGroup,
        RoundDecimalDigitsGroup,
        RoundIntegerGroup
    >
{
    public RoundingDecimalGroup(FloorIntegerGroup value)
        : this(
            (OneOf<
                FloorIntegerGroup,
                CeilingIntegerGroup,
                RoundDecimalDigitsGroup,
                RoundIntegerGroup
            >)
                value
        )
    { }

    public RoundingDecimalGroup(CeilingIntegerGroup value)
        : this(
            (OneOf<
                FloorIntegerGroup,
                CeilingIntegerGroup,
                RoundDecimalDigitsGroup,
                RoundIntegerGroup
            >)
                value
        )
    { }

    public RoundingDecimalGroup(RoundDecimalDigitsGroup value)
        : this(
            (OneOf<
                FloorIntegerGroup,
                CeilingIntegerGroup,
                RoundDecimalDigitsGroup,
                RoundIntegerGroup
            >)
                value
        )
    { }

    public RoundingDecimalGroup(RoundIntegerGroup value)
        : this(
            (OneOf<
                FloorIntegerGroup,
                CeilingIntegerGroup,
                RoundDecimalDigitsGroup,
                RoundIntegerGroup
            >)
                value
        )
    { }

    private RoundingDecimalGroup(
        OneOf<
            FloorIntegerGroup,
            CeilingIntegerGroup,
            RoundDecimalDigitsGroup,
            RoundIntegerGroup
        > input
    )
        : base(input) { }
}
