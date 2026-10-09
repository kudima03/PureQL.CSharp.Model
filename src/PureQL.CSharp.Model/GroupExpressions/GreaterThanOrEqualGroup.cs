using OneOf;

namespace PureQL.CSharp.Model.GroupExpressions;

public sealed class GreaterThanOrEqualGroup
    : OneOfBase<
        GreaterThanOrEqualDecimalGroup,
        GreaterThanOrEqualStringGroup,
        GreaterThanOrEqualDateGroup,
        GreaterThanOrEqualTimeGroup,
        GreaterThanOrEqualDatetimeGroup
    >
{
    public GreaterThanOrEqualGroup(GreaterThanOrEqualDecimalGroup value)
        : this(
            (OneOf<
                GreaterThanOrEqualDecimalGroup,
                GreaterThanOrEqualStringGroup,
                GreaterThanOrEqualDateGroup,
                GreaterThanOrEqualTimeGroup,
                GreaterThanOrEqualDatetimeGroup
            >)
                value
        )
    { }

    public GreaterThanOrEqualGroup(GreaterThanOrEqualStringGroup value)
        : this(
            (OneOf<
                GreaterThanOrEqualDecimalGroup,
                GreaterThanOrEqualStringGroup,
                GreaterThanOrEqualDateGroup,
                GreaterThanOrEqualTimeGroup,
                GreaterThanOrEqualDatetimeGroup
            >)
                value
        )
    { }

    public GreaterThanOrEqualGroup(GreaterThanOrEqualDateGroup value)
        : this(
            (OneOf<
                GreaterThanOrEqualDecimalGroup,
                GreaterThanOrEqualStringGroup,
                GreaterThanOrEqualDateGroup,
                GreaterThanOrEqualTimeGroup,
                GreaterThanOrEqualDatetimeGroup
            >)
                value
        )
    { }

    public GreaterThanOrEqualGroup(GreaterThanOrEqualTimeGroup value)
        : this(
            (OneOf<
                GreaterThanOrEqualDecimalGroup,
                GreaterThanOrEqualStringGroup,
                GreaterThanOrEqualDateGroup,
                GreaterThanOrEqualTimeGroup,
                GreaterThanOrEqualDatetimeGroup
            >)
                value
        )
    { }

    public GreaterThanOrEqualGroup(GreaterThanOrEqualDatetimeGroup value)
        : this(
            (OneOf<
                GreaterThanOrEqualDecimalGroup,
                GreaterThanOrEqualStringGroup,
                GreaterThanOrEqualDateGroup,
                GreaterThanOrEqualTimeGroup,
                GreaterThanOrEqualDatetimeGroup
            >)
                value
        )
    { }

    private GreaterThanOrEqualGroup(
        OneOf<
            GreaterThanOrEqualDecimalGroup,
            GreaterThanOrEqualStringGroup,
            GreaterThanOrEqualDateGroup,
            GreaterThanOrEqualTimeGroup,
            GreaterThanOrEqualDatetimeGroup
        > input
    )
        : base(input) { }
}
