using OneOf;

namespace PureQL.CSharp.Model.GroupExpressions;

public sealed class LessThanOrEqualGroup
    : OneOfBase<
        LessThanOrEqualDecimalGroup,
        LessThanOrEqualStringGroup,
        LessThanOrEqualDateGroup,
        LessThanOrEqualTimeGroup,
        LessThanOrEqualDatetimeGroup
    >
{
    public LessThanOrEqualGroup(LessThanOrEqualDecimalGroup value)
        : this(
            (OneOf<
                LessThanOrEqualDecimalGroup,
                LessThanOrEqualStringGroup,
                LessThanOrEqualDateGroup,
                LessThanOrEqualTimeGroup,
                LessThanOrEqualDatetimeGroup
            >)
                value
        )
    { }

    public LessThanOrEqualGroup(LessThanOrEqualStringGroup value)
        : this(
            (OneOf<
                LessThanOrEqualDecimalGroup,
                LessThanOrEqualStringGroup,
                LessThanOrEqualDateGroup,
                LessThanOrEqualTimeGroup,
                LessThanOrEqualDatetimeGroup
            >)
                value
        )
    { }

    public LessThanOrEqualGroup(LessThanOrEqualDateGroup value)
        : this(
            (OneOf<
                LessThanOrEqualDecimalGroup,
                LessThanOrEqualStringGroup,
                LessThanOrEqualDateGroup,
                LessThanOrEqualTimeGroup,
                LessThanOrEqualDatetimeGroup
            >)
                value
        )
    { }

    public LessThanOrEqualGroup(LessThanOrEqualTimeGroup value)
        : this(
            (OneOf<
                LessThanOrEqualDecimalGroup,
                LessThanOrEqualStringGroup,
                LessThanOrEqualDateGroup,
                LessThanOrEqualTimeGroup,
                LessThanOrEqualDatetimeGroup
            >)
                value
        )
    { }

    public LessThanOrEqualGroup(LessThanOrEqualDatetimeGroup value)
        : this(
            (OneOf<
                LessThanOrEqualDecimalGroup,
                LessThanOrEqualStringGroup,
                LessThanOrEqualDateGroup,
                LessThanOrEqualTimeGroup,
                LessThanOrEqualDatetimeGroup
            >)
                value
        )
    { }

    private LessThanOrEqualGroup(
        OneOf<
            LessThanOrEqualDecimalGroup,
            LessThanOrEqualStringGroup,
            LessThanOrEqualDateGroup,
            LessThanOrEqualTimeGroup,
            LessThanOrEqualDatetimeGroup
        > input
    )
        : base(input) { }
}
